Imports DXDAL.SPGData
Imports System.Text
Imports System.Threading
Imports System.Drawing.Printing
Imports DevExpress.Xpo

Public Class LPNLabel

    Private Shared lpnTextLabel As String

    Public Shared Function GetNextLPNNumber(customer As Customers) As Integer

        Dim nextLPN As Integer = 0
        'Dim i As Integer = 0

        'While i < 50
        'Try
        customer.Reload()
        If customer.NextLPNNumber > 0 Then
            nextLPN = customer.NextLPNNumber
            customer.NextLPNNumber += 1
            customer.Save()
        Else
            If customer.FirstLPNNumber.HasValue Then
                nextLPN = customer.FirstLPNNumber.Value
                customer.NextLPNNumber = nextLPN + 1
                customer.Save()
            End If
        End If
        'i = 50
        'Catch
        '    Thread.Sleep(100)
        '    i += 1
        'End Try
        'End While

        If nextLPN > customer.LastLPNNumber Then
            MessageBox.Show("You ran out of LPN numbers, you must provide a different range of numbers before creating a new LPN number")
            nextLPN = 0
        End If

        If nextLPN = customer.LastLPNNumber Then
            MessageBox.Show("You used now your last LPN number, please provide a different range of numbers before creating a new LPN number")
        End If

        Return nextLPN

    End Function
    Public Shared Function GetNextLPNNumber(customerId As Integer) As Integer
        Dim customer As Customers = Session.DefaultSession.GetObjectByKey(Of Customers)(customerId)
        Return GetNextLPNNumber(customer)
    End Function



    Private Shared Sub CreateLargeLPNLabel(ByVal session As Session, ByVal horizontalAdjustment As Byte, ByVal verticalAdjustment As Byte, ByVal inventoryRecord As Inventory, ByVal lpnBaseNumber As Integer, ByVal printCopies As Byte,
                                           ByVal largeCode As String, ByVal lpnNumber As String)

        Dim Description1End As Integer

        Dim LPNPrintOutput As StringBuilder = New StringBuilder()
        Dim inventoryItemDescription As String = inventoryRecord.InventoryItemID.ItemDescription

        LPNPrintOutput.Append(String.Format("^XA{0}^SZ2^JMA{0}^MCY^PMN{0}^PW802{0}~JSN{0}^JZY{0}^LH{1},{2}^LRN{0}^XZ{0}", vbCrLf, horizontalAdjustment, verticalAdjustment))
        LPNPrintOutput.Append(String.Format("^XA{0}^CI0{0}", vbCrLf))
        LPNPrintOutput.Append(String.Format("^FT38,367{1}^A0B,23,20^FDPlant # - ^FS{1}^FT38,286{1}^A0B,23,20^FD{0}^FS{1}", inventoryRecord.InventoryItemID.ItemCustomerID.PlantCode, vbCrLf))
        LPNPrintOutput.Append(String.Format("^FT35,1270{1}^A0B,23,24^FDLICENSE PLATE NUMBER^FS{1}^FT83,1270{1}^A0B,60,86^FD{0}^FS{1}", lpnNumber, vbCrLf))
        LPNPrintOutput.Append(String.Format("^FO88,100{1}^BY7^BCB,160,N,N^FD>:{0}^FS{1}", lpnNumber, vbCrLf))
        LPNPrintOutput.Append(String.Format("^FO251,78{0}^GB0,1397,4^FS{0}^FO253,776{0}^GB68,0,2^FS{0}", vbCrLf))
        If String.IsNullOrEmpty(inventoryItemDescription) = False Then
            If inventoryItemDescription.Length > 36 Then
                Description1End = inventoryItemDescription.LastIndexOf(" ", 36)
                LPNPrintOutput.Append(String.Format("^FT283,774{1}^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription.Substring(0, Description1End), vbCrLf))
            Else
                LPNPrintOutput.Append(String.Format("^FT283,774{1}^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription, vbCrLf))
            End If
        End If
        If String.IsNullOrEmpty(inventoryItemDescription) = False Then
            If inventoryItemDescription.Length >= Description1End + 35 Then
                LPNPrintOutput.Append(String.Format("^FT313,770{1}^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription.Substring(Description1End + 1, inventoryItemDescription.LastIndexOf(" ", 35)), vbCrLf))
            ElseIf inventoryItemDescription.Length > 36 Then
                LPNPrintOutput.Append(String.Format("^FT313,770{1}^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription.Substring(Description1End + 1), vbCrLf))
            End If
        End If
        LPNPrintOutput.Append(String.Format("^FT275,1462{1}^A0B,23,32^FDMATERIAL NUMBER - DESCRIPTION^FS{1}^FT318,1462{1}^A0B,56,77^FD{0}^FS{1}", inventoryRecord.InventoryItemID.ItemCode, vbCrLf))
        LPNPrintOutput.Append(String.Format("^FO321,487{0}^GB0,988,2^FS{0}^FO321,1131{0}^GB220,0,2^FS{0}^FO321,80{0}^GB0,406,2^FS{0}", vbCrLf))
        LPNPrintOutput.Append(GetLPNINventoryRecords(session, lpnBaseNumber, inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID, inventoryRecord.InventoryDate, inventoryRecord))
        LPNPrintOutput.Append(String.Format("^FO539,77{0}^GB0,1397,2^FS{0}^FO542,771{0}^GB76,0,2^FS{0}^FO542,1131{0}^GB76,0,2^FS{0}^FO322,486{0}^GB296,0,2^FS{0}", vbCrLf))
        LPNPrintOutput.Append(String.Format("^FT561,476{1}^A0B,23,32^FDCREATED TIMESTAMP^FS{1}^FT604,472{1}^A0B,28,39^FD{0}^FS{1}", Now.ToString("MM/dd/yyyy hh:mm:ss tt"), vbCrLf))
        LPNPrintOutput.Append(String.Format("^FT561,759{1}^A0B,23,32^FDUOM^FS{1}^FT611,759{1}^A0B,56,77^FD{0}^FS{1}", inventoryRecord.InventoryItemID.strUnitOfMeasure, vbCrLf))
        LPNPrintOutput.Append(String.Format("^FT561,1120{1}^A0B,23,32^FDPRODUCTION DATE^FS{1}^FT611,1120{1}^A0B,51,70^FD{0}^FS{1}", inventoryRecord.InventoryDate.ToString("M/d/yyyy"), vbCrLf))
        LPNPrintOutput.Append(String.Format("^FT561,1462{1}^A0B,23,32^FDTOTAL QUANTITY^FS{1}^FT611,1462{1}^A0B,51,70^FD{0}^FS{1}",
                                            InventoryBLL.GetLPNQuantity(session, lpnBaseNumber, inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID, inventoryRecord.InventoryDate, inventoryRecord).ToString, vbCrLf))
        LPNPrintOutput.Append(String.Format("^FO617,78{0}^GB0,1397,2^FS{0}", vbCrLf))
        LPNPrintOutput.Append(String.Format("^FO623,80{1}^BY3^BCB,127,N,N^FD>;{0}^FS{1}", largeCode, vbCrLf))
        LPNPrintOutput.Append(String.Format("^PQ{0},0,1,Y{1}^XZ", printCopies, vbCrLf))

        lpnTextLabel = LPNPrintOutput.ToString()

    End Sub

    Public Shared Function CreateLPNLabel(ByVal session As Session, ByVal inventoryRecord As Inventory, ByVal shortLPN As Boolean) As String

        Dim addMForMultiple As Boolean = False

        If VerifyLPNSettings(inventoryRecord.InventoryItemID.ItemCustomerID) Then
            Dim LPNBaseNumber As Integer
            Dim LPNSettings As CompanySettings = CompanySettingsBLL.GetSettings

            If inventoryRecord.LPNNumber.HasValue AndAlso inventoryRecord.LPNNumber.Value > 0 Then
                LPNBaseNumber = inventoryRecord.LPNNumber.Value
            Else
                LPNBaseNumber = GetNextLPNNumber(inventoryRecord.InventoryItemID.ItemCustomerID)
                inventoryRecord.LPNNumber = LPNBaseNumber
                inventoryRecord.FullLPNNumber = inventoryRecord.InventoryItemID.ItemCustomerID.LPNPrefix &
                        Right("0000000000" & LPNBaseNumber.ToString, Len(inventoryRecord.InventoryItemID.ItemCustomerID.LastLPNNumber.ToString))
                inventoryRecord.Save()
            End If

            If shortLPN = False AndAlso InventoryBLL.IsMultiLPN(session, LPNBaseNumber, inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID, inventoryRecord.InventoryDate) Then
                addMForMultiple = True
            End If

            Dim largeCode As String = GetLPNLargeCode(session, inventoryRecord, addMForMultiple)
            Dim LPNSuffix As String = Right("0000000000" & LPNBaseNumber.ToString, Len(inventoryRecord.InventoryItemID.ItemCustomerID.LastLPNNumber.ToString))
            Dim LPNNumber As String = inventoryRecord.InventoryItemID.ItemCustomerID.LPNPrefix & LPNSuffix

            If LPNBaseNumber = 0 Then
                Return String.Empty
            End If

            If shortLPN Then
                CreateShortLPNLabel(session, LPNSettings.LPNHorizontalAdjustment, LPNSettings.LPNVerticalAdjustment, inventoryRecord, LPNBaseNumber, LPNSettings.LPNPrintCopies, largeCode, LPNNumber)
            Else
                CreateLargeLPNLabel(session, LPNSettings.LPNHorizontalAdjustment, LPNSettings.LPNVerticalAdjustment, inventoryRecord, LPNBaseNumber, LPNSettings.LPNPrintCopies, largeCode, LPNNumber)
            End If

            Return lpnTextLabel
        End If

        Return String.Empty

    End Function

    Private Shared Sub CreateShortLPNLabel(ByVal session As Session, ByVal horizontalAdjustment As Byte, ByVal verticalAdjustment As Byte, ByVal inventoryRecord As Inventory, ByVal lpnBaseNumber As Integer, ByVal printCopies As Byte,
                                           ByVal largeCode As String, ByVal lpnNumber As String)

        Dim Description1End As Integer

        Dim LPNPrintOutput As StringBuilder = New StringBuilder()
        Dim inventoryItemDescription As String = inventoryRecord.InventoryItemID.ItemDescription

        LPNPrintOutput.Append(String.Format("^XA{0}^SZ2^JMA{0}^MCY^PMN{0}^PW802{0}~JSN{0}^JZY{0}^LH{1},{2}^LRN{0}^XZ{0}", vbCrLf, horizontalAdjustment, verticalAdjustment))
        LPNPrintOutput.Append(String.Format("^XA{0}^FT452,1172{0}^CI0{0}", vbCrLf))
        LPNPrintOutput.Append(String.Format("        ^A0B,62,85^FD{0}^FS{1}", inventoryRecord.InventoryItemID.ItemCode, vbCrLf))
        LPNPrintOutput.Append("        ^FT537,829" & vbCrLf)
        LPNPrintOutput.Append(String.Format("        ^A0B,56,77^FD{0}^FS{1}", inventoryRecord.InventoryItemID.strUnitOfMeasure, vbCrLf))
        LPNPrintOutput.Append("        ^FT482,829" & vbCrLf)
        LPNPrintOutput.Append("        ^A0B,23,32^FDUOM^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FT482,1172" & vbCrLf)
        LPNPrintOutput.Append("        ^A0B,23,32^FDQUANTITY^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FT537,1171" & vbCrLf)
        LPNPrintOutput.Append(String.Format("        ^A0B,56,77^FD{0}^FS{1}", InventoryBLL.GetLPNQuantity(session, lpnBaseNumber, inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID,
                                                                                                          inventoryRecord.InventoryDate, inventoryRecord).ToString, vbCrLf))
        LPNPrintOutput.Append("        ^FO372,78" & vbCrLf)
        LPNPrintOutput.Append("        ^GB0,1097,4^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FO462,487" & vbCrLf)
        LPNPrintOutput.Append("        ^GB0,688,2^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FO539,841" & vbCrLf)
        LPNPrintOutput.Append("        ^GB76,0,2^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FO539,460" & vbCrLf)
        LPNPrintOutput.Append("        ^GB76,0,2^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FO614,78" & vbCrLf)
        LPNPrintOutput.Append("        ^GB0,1097,2^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FO538,77" & vbCrLf)
        LPNPrintOutput.Append("        ^GB0,1097,2^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FT426,474" & vbCrLf)
        If String.IsNullOrEmpty(inventoryItemDescription) = False Then
            If inventoryItemDescription.Length > 20 Then
                Description1End = inventoryRecord.InventoryItemID.ItemDescription.LastIndexOf(" ", 20)
                LPNPrintOutput.Append(String.Format("        ^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription.Substring(0, Description1End), vbCrLf))
            Else
                LPNPrintOutput.Append(String.Format("        ^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription, vbCrLf))
            End If
        Else
            LPNPrintOutput.Append(String.Format("        ^A0B,31,43^FD{0}^FS{1}", String.Empty, vbCrLf))
        End If
        LPNPrintOutput.Append("        ^FT393,1172" & vbCrLf)
        LPNPrintOutput.Append("        ^A0B,23,32^FDMATERIAL NUMBER^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FT495,474" & vbCrLf)
        LPNPrintOutput.Append("        ^A0B,23,32^FDGENERAL STOCKING LOCATION^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FT558,1172" & vbCrLf)
        LPNPrintOutput.Append("        ^A0B,23,32^FDPRODUCTION DATE^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FT558,829" & vbCrLf)
        LPNPrintOutput.Append("        ^A0B,23,32^FDDATE CODE^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FT608,829" & vbCrLf)
        'LPNPrintOutput.Append(String.Format("        ^A0B,51,70^FD{0}^FS{1}", GetDateCode(inventoryRecord), vbCrLf))
        'If isMulti Then
        '    LPNPrintOutput.Append(String.Format("        ^A0B,51,70^FD{0}M^FS{1}", inventoryRecord.Lot, vbCrLf))
        'Else
        LPNPrintOutput.Append(String.Format("        ^A0B,51,70^FD{0}^FS{1}", inventoryRecord.Lot, vbCrLf))
        'End If
        LPNPrintOutput.Append("        ^FT534,474" & vbCrLf)
        LPNPrintOutput.Append(String.Format("        ^A0B,39,54^FD{0}^FS{1}", String.Empty, vbCrLf))
        LPNPrintOutput.Append("        ^FO121,88" & vbCrLf)
        LPNPrintOutput.Append(String.Format("        ^BY8^BCB,241,N,Y^FD>:{0}^FS{1}", lpnNumber, vbCrLf))
        LPNPrintOutput.Append("        ^FT113,1189" & vbCrLf)
        LPNPrintOutput.Append(String.Format("        ^A0B,68,94^FD{0}^FS{1}", lpnNumber, vbCrLf))
        LPNPrintOutput.Append("        ^FT38,347" & vbCrLf)
        LPNPrintOutput.Append("        ^A0B,23,20^FDPlant # - ^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FO615,80" & vbCrLf)
        LPNPrintOutput.Append(String.Format("        ^BY4^BCB,127,N,N^FD>;{0}^FS{1}", largeCode, vbCrLf))
        LPNPrintOutput.Append("        ^FT601,448" & vbCrLf)
        LPNPrintOutput.Append(String.Format("        ^A0B,28,39^FD{0}^FS{1}", Now.ToString("MM/dd/yyyy hh:mm:ss tt"), vbCrLf))
        LPNPrintOutput.Append("        ^FO463,841" & vbCrLf)
        LPNPrintOutput.Append("        ^GB76,0,2^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FO374,486" & vbCrLf)
        LPNPrintOutput.Append("        ^GB165,0,2^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FT393,474" & vbCrLf)
        LPNPrintOutput.Append("        ^A0B,23,32^FDDESCRIPTION^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FT464,461" & vbCrLf)
        If String.IsNullOrEmpty(inventoryItemDescription) = False Then
            If inventoryItemDescription.Length >= 40 Then
                LPNPrintOutput.Append(String.Format("        ^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription.Substring(Description1End + 1, inventoryItemDescription.LastIndexOf(" ", 20)), vbCrLf))
            ElseIf inventoryItemDescription.Length > 20 Then
                LPNPrintOutput.Append(String.Format("        ^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription.Substring(Description1End + 1), vbCrLf))
            Else
                LPNPrintOutput.Append(String.Format("        ^A0B,31,43^FD{0}^FS{1}", String.Empty, vbCrLf))
            End If
        Else
            LPNPrintOutput.Append(String.Format("        ^A0B,31,43^FD{0}^FS{1}", String.Empty, vbCrLf))
        End If
        LPNPrintOutput.Append("        ^FT38,1184" & vbCrLf)
        LPNPrintOutput.Append("        ^A0B,23,24^FDLICENSE PLATE NUMBER^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FT558,461" & vbCrLf)
        LPNPrintOutput.Append("        ^A0B,23,32^FDCREATED TIMESTAMP^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FT608,1172" & vbCrLf)
        LPNPrintOutput.Append(String.Format("        ^A0B,51,70^FD{0}^FS{1}", inventoryRecord.InventoryDate.ToString("M/d/yyyy"), vbCrLf))
        LPNPrintOutput.Append("        ^FO475,80" & vbCrLf)
        LPNPrintOutput.Append("        ^GB0,406,2^FS" & vbCrLf)
        LPNPrintOutput.Append("        ^FT38,131" & vbCrLf)
        LPNPrintOutput.Append(String.Format("        ^A0B,23,20^FD{0}^FS{1}", inventoryRecord.InventoryItemID.ItemCustomerID.PlantCode, vbCrLf))
        LPNPrintOutput.Append(String.Format("        ^PQ{0},0,1,Y{1}", printCopies, vbCrLf))
        LPNPrintOutput.Append("        ^XZ" & vbCrLf & vbCrLf & vbCrLf)

        lpnTextLabel = LPNPrintOutput.ToString()

    End Sub

    Private Shared Function GetLPNINventoryRecords(ByVal session As Session, ByVal lpnBaseNumber As Integer, ByVal customerID As Integer, ByVal inventoryDate As Date, ByVal currentRecord As Inventory) As String

        Const position As Integer = 343

        Dim i As Integer = 1
        Dim LPNPrintOutput As StringBuilder = New StringBuilder()

        LPNPrintOutput.Append(String.Format("^FT{0},1462{1}^A0B,23,32^FDQUANTITY^FS{1}", position, vbCrLf))
        LPNPrintOutput.Append(String.Format("^FT{0},1119{1}^A0B,23,32^FDDATE CODE^FS{1}", position, vbCrLf))
        LPNPrintOutput.Append(String.Format("^FT{0},474{1}^A0B,23,32^FDEXPIRATION DATE^FS{1}", position, vbCrLf))

        For Each record As Inventory In InventoryBLL.GetLPNInventoryRecords(session, lpnBaseNumber, customerID, inventoryDate)
            If record IsNot currentRecord AndAlso record.IsDeleted = False Then
                LPNPrintOutput.Append(String.Format("^FT{0},1462{2}^A0B,56,77^FD{1}^FS{2}", position + (i * 44), record.InventoryQuantity, vbCrLf))
                LPNPrintOutput.Append(String.Format("^FT{0},1119{2}^A0B,51,70^FD{1}^FS{2}", position + (i * 44), record.Lot, vbCrLf))
                If (record.ExpirationDate.HasValue) Then
                    LPNPrintOutput.Append(String.Format("^FT{0},474{2}^A0B,51,70^FD{1}^FS{2}", position + (i * 44), record.ExpirationDate.Value.ToString(record.InventoryItemID.ItemCustomerID.ExpirationDateFormat), vbCrLf))
                End If
                i += 1
                If i = 4 Then
                    Exit For
                End If
            End If
        Next

        LPNPrintOutput.Append(String.Format("^FT{0},1462{2}^A0B,56,77^FD{1}^FS{2}", position + (i * 44), currentRecord.InventoryQuantity, vbCrLf))
        LPNPrintOutput.Append(String.Format("^FT{0},1119{2}^A0B,51,70^FD{1}^FS{2}", position + (i * 44), currentRecord.Lot, vbCrLf))
        If (currentRecord.ExpirationDate.HasValue) Then
            LPNPrintOutput.Append(String.Format("^FT{0},474{2}^A0B,51,70^FD{1}^FS{2}", position + (i * 44), currentRecord.ExpirationDate.Value.ToString(currentRecord.InventoryItemID.ItemCustomerID.ExpirationDateFormat), vbCrLf))
        End If

        Return LPNPrintOutput.ToString

    End Function

    Private Shared Function VerifyLPNSettings(ByVal customer As Customers) As Boolean

        If String.IsNullOrEmpty(customer.LPNPrefix) Then
            MessageBox.Show(String.Format("There's no LPN Prefix set up for {0}.{1}You must set up all the LPN settings for {0} before generating an LPN Label.", customer.CustomerName, vbCrLf))
            Return False
        End If

        If customer.FirstLPNNumber.HasValue = False OrElse customer.LastLPNNumber.HasValue = False OrElse customer.FirstLPNNumber.Value < 1 Then
            MessageBox.Show(String.Format("The number range for LPN numbers is not set up for {0}.{1}You must set up all the LPN settings for {0} before generating an LPN Label.", customer.CustomerName, vbCrLf))
            Return False
        End If

        If String.IsNullOrEmpty(customer.PlantCode) Then
            MessageBox.Show(String.Format("There's no Plant Code set up for {0}.{1}You must set up all the LPN settings for {0} before generating an LPN Label.", customer.CustomerName, vbCrLf))
            Return False
        End If

        If String.IsNullOrEmpty(CompanySettingsBLL.GetLPNPrinter) Then
            MessageBox.Show(String.Format("There's no LPN Printer set up.{0}You must set up all the LPN settings before generating an LPN Label.", vbCrLf))
            Return False
        End If

        Return True

    End Function

    Private Shared Function GetLPNLargeCode(ByVal session As Session, ByVal inventoryRecord As Inventory, ByVal isMulti As Boolean) As String

        Dim itemNumber As String = Right("0000000000000" & inventoryRecord.InventoryItemID.ItemCode.Replace("-", ""), 13)
        Dim quantity As String = Right("00000" & InventoryBLL.GetLPNQuantity(session, inventoryRecord.LPNNumber.Value, inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID, inventoryRecord.InventoryDate, inventoryRecord).ToString, 5)
        Dim prodDate As String = inventoryRecord.InventoryDate.ToString("yyyyMMdd")

        ' ">6" switches to code C for the alpha part of the barcode
        If isMulti Then
            Return String.Format("{0}{1}{2}>6{3}M", itemNumber, quantity, prodDate, inventoryRecord.Lot)
        Else
            Return String.Format("{0}{1}{2}>6{3}", itemNumber, quantity, prodDate, inventoryRecord.Lot)
        End If


    End Function

    Private Shared Function GetDateCode(ByVal inventoryRecord As Inventory) As String

        Dim overflow As Boolean = inventoryRecord.InventoryDate.Day > 15

        Dim seq1 As Integer = ((((inventoryRecord.InventoryDate.Year - 4) Mod 11) * 12 + inventoryRecord.InventoryDate.Month - 1) Mod 44) * 2 + 11
        Dim seq2 As Integer = If(overflow, seq1 + 1, seq1)
        Dim pos2 As Integer = If(overflow, inventoryRecord.InventoryDate.Day - 15, inventoryRecord.InventoryDate.Day)

        Return seq2.ToString & Mid("ABCDEFGHJKLMNPRS", pos2, 1) & inventoryRecord.InventoryItemID.ItemCustomerID.PlantCode.ToString & inventoryRecord.Shift.ShiftName

    End Function

    Public Shared Sub SendLPNLabelToGenericPrinter(ByVal printer As String, ByVal textLabel As String)
        'Dim s As String
        'Dim pd As New PrintDialog()

        '' You need a string to send.
        's = "Hello, this is a test"
        '' Open the printer dialog box, and then allow the user to select a printer.
        'pd.PrinterSettings = New PrinterSettings()
        'If (pd.ShowDialog() = DialogResult.OK) Then
        RawPrinterHelper.SendStringToPrinter(printer, textLabel)
        'End If

    End Sub

    Private Shared Sub SendLPNLabelToPrinter(ByVal printer As String)

        Dim document As New PrintDocument
        document.PrinterSettings.PrinterName = printer
        AddHandler document.PrintPage, AddressOf PrintingLPNLabel
        document.Print()

    End Sub

    Private Shared Sub PrintingLPNLabel(sender As Object, e As PrintPageEventArgs)

        e.Graphics.DrawString(lpnTextLabel, New Font("Arial", 10), Brushes.Black, New Point(0, 0))

    End Sub

End Class
