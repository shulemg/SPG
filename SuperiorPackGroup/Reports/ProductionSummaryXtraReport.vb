Imports System.Linq
Imports DevExpress
Imports DXDAL.SPGData

Public Class ProductionSummaryXtraReport

    Private m_BreakMinutes As Long
    Private m_Minutes As Integer
    Private m_TimeDiffStartToStop As Long
    Private m_MinPerHour As Integer = 50
    Private m_CurrentProduction As Production

    Private Sub ProductionSummaryXtraReport_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint

        'm_MinPerHour = My.Forms.MainXtraForm.MinPerHOur

    End Sub

    Private Sub totalMinutes_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles totalMinutes.BeforePrint

        Dim hours As Integer = CInt(totalHours.Summary.GetResult.ToString.Substring(0, totalHours.Summary.GetResult.ToString.IndexOf(":"))) * 60
        Dim minutes As Integer = CInt(totalHours.Summary.GetResult.ToString.Substring(totalHours.Summary.GetResult.ToString.IndexOf(":") + 1)) + hours
        totalMinutes.Text = CStr(((minutes - m_BreakMinutes) / 60) * m_MinPerHour)

    End Sub

    Private Sub averageActualSpeed_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles averageActualSpeed.BeforePrint

        Dim hours As Integer = CInt(totalHours.Summary.GetResult.ToString.Substring(0, totalHours.Summary.GetResult.ToString.IndexOf(":"))) * 60
        Dim minutes As Integer = CInt(totalHours.Summary.GetResult.ToString.Substring(totalHours.Summary.GetResult.ToString.IndexOf(":") + 1)) + hours
        averageActualSpeed.Text = Format(CDbl(AverageActualSpeedH.Summary.GetResult) / CType((((minutes - m_BreakMinutes) / 60) * m_MinPerHour), Integer), "0.00")

    End Sub

    Private Sub totalPacksPerMin_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles totalPacksPerMin.BeforePrint

        Dim hours As Integer = CInt(totalHours.Summary.GetResult.ToString.Substring(0, totalHours.Summary.GetResult.ToString.IndexOf(":"))) * 60
        Dim minutes As Double = ((CInt(totalHours.Summary.GetResult.ToString.Substring(totalHours.Summary.GetResult.ToString.IndexOf(":") + 1)) + hours) / 60) * m_MinPerHour
        totalPacksPerMin.Text = Format(CDbl(totalQtyProduced.Summary.GetResult) / (minutes - m_BreakMinutes), "0.00")

    End Sub

    Private Sub totalMinutesLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles totalMinutesLabel.BeforePrint

        totalMinutesLabel.Text = String.Format("Total Minutes ({0}/Hour)", m_MinPerHour)

    End Sub

    Private Sub totalHours_SummaryGetResult(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles totalHours.SummaryGetResult

        e.Result = String.Format("{0}:{1}", Strings.Format(m_Minutes \ 60, "##############0"), Strings.Format((m_Minutes Mod 60) \ 1, "00"))
        e.Handled = True

    End Sub

    Private Sub totalHours_SummaryReset(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles totalHours.SummaryReset

        m_Minutes = 0

    End Sub

    Private Sub totalHours_SummaryRowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles totalHours.SummaryRowChanged

        m_Minutes += CInt(DateDiff(DateInterval.Minute, Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop"))) - _
                        (BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(GetCurrentColumnValue("ProdMainDate")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), _
                                                      Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")))))

    End Sub

    Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint

        m_TimeDiffStartToStop = DateDiff(DateInterval.Minute, Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")))
        m_BreakMinutes = BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(GetCurrentColumnValue("ProdMainDate")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), _
                                                      Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")))

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
            Else If m_CurrentProduction.ProdMainItemID.MinutesPerShift > 0
                m_MinPerHour = CInt(m_CurrentProduction.ProdMainItemID.MinutesPerShift / 7.1667)              
            Else
                m_MinPerHour = MainXtraForm.MinPerHOur
            End If
        Else
            m_MinPerHour = MainXtraForm.MinPerHOur
        End If

    End Sub

End Class