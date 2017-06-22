<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ProductSpecificationsXtraReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel
        Me.specialInstructionsXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPanel3 = New DevExpress.XtraReports.UI.XRPanel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.palletPaternXrPictureBox = New DevExpress.XtraReports.UI.XRPictureBox
        Me.shelfLifeXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.caseCodeXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.packageCodeXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.layersPerPalletXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.casesPerLayerXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.casesPerPalletXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.unitsPerCaseXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.mavXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.requiredWeightXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.itemBomsXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel
        Me.itemDescriptionXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.itemCodeXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel2, Me.shelfLifeXrLabel, Me.XrLabel11, Me.caseCodeXrLabel, Me.XrLabel10, Me.packageCodeXrLabel, Me.XrLabel9, Me.layersPerPalletXrLabel, Me.XrLabel8, Me.casesPerLayerXrLabel, Me.XrLabel7, Me.casesPerPalletXrLabel, Me.XrLabel6, Me.unitsPerCaseXrLabel, Me.XrLabel5, Me.mavXrLabel, Me.XrLabel4, Me.requiredWeightXrLabel, Me.XrLabel3, Me.itemBomsXrLabel, Me.XrLabel2, Me.XrPanel1})
        Me.Detail.Height = 842
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPanel2
        '
        Me.XrPanel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.specialInstructionsXrLabel, Me.XrLabel13, Me.XrPanel3})
        Me.XrPanel2.Location = New System.Drawing.Point(0, 425)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.Size = New System.Drawing.Size(650, 400)
        Me.XrPanel2.StylePriority.UseBorders = False
        '
        'specialInstructionsXrLabel
        '
        Me.specialInstructionsXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.specialInstructionsXrLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.specialInstructionsXrLabel.Location = New System.Drawing.Point(0, 25)
        Me.specialInstructionsXrLabel.Name = "specialInstructionsXrLabel"
        Me.specialInstructionsXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.specialInstructionsXrLabel.Size = New System.Drawing.Size(650, 200)
        Me.specialInstructionsXrLabel.StylePriority.UseBorders = False
        Me.specialInstructionsXrLabel.StylePriority.UseFont = False
        Me.specialInstructionsXrLabel.StylePriority.UseTextAlignment = False
        Me.specialInstructionsXrLabel.Text = "specialInstructionsXrLabel"
        Me.specialInstructionsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.Size = New System.Drawing.Size(650, 25)
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "Special Instructions"
        '
        'XrPanel3
        '
        Me.XrPanel3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.palletPaternXrPictureBox})
        Me.XrPanel3.Location = New System.Drawing.Point(500, 225)
        Me.XrPanel3.Name = "XrPanel3"
        Me.XrPanel3.Size = New System.Drawing.Size(150, 175)
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.Size = New System.Drawing.Size(150, 25)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Pallet Patern"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'palletPaternXrPictureBox
        '
        Me.palletPaternXrPictureBox.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.palletPaternXrPictureBox.Location = New System.Drawing.Point(0, 25)
        Me.palletPaternXrPictureBox.Name = "palletPaternXrPictureBox"
        Me.palletPaternXrPictureBox.Size = New System.Drawing.Size(150, 150)
        Me.palletPaternXrPictureBox.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.palletPaternXrPictureBox.StylePriority.UseBorders = False
        '
        'shelfLifeXrLabel
        '
        Me.shelfLifeXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.shelfLifeXrLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.shelfLifeXrLabel.Location = New System.Drawing.Point(100, 400)
        Me.shelfLifeXrLabel.Name = "shelfLifeXrLabel"
        Me.shelfLifeXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.shelfLifeXrLabel.Size = New System.Drawing.Size(550, 25)
        Me.shelfLifeXrLabel.StylePriority.UseBorders = False
        Me.shelfLifeXrLabel.StylePriority.UseFont = False
        Me.shelfLifeXrLabel.StylePriority.UseTextAlignment = False
        Me.shelfLifeXrLabel.Text = "shelfLifeXrLabel"
        Me.shelfLifeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.Location = New System.Drawing.Point(0, 400)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Shelf Life"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'caseCodeXrLabel
        '
        Me.caseCodeXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.caseCodeXrLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.caseCodeXrLabel.Location = New System.Drawing.Point(100, 350)
        Me.caseCodeXrLabel.Name = "caseCodeXrLabel"
        Me.caseCodeXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.caseCodeXrLabel.Size = New System.Drawing.Size(550, 50)
        Me.caseCodeXrLabel.StylePriority.UseBorders = False
        Me.caseCodeXrLabel.StylePriority.UseFont = False
        Me.caseCodeXrLabel.StylePriority.UseTextAlignment = False
        Me.caseCodeXrLabel.Text = "caseCodeXrLabel"
        Me.caseCodeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.Location = New System.Drawing.Point(0, 350)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(100, 50)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Case Code Format"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'packageCodeXrLabel
        '
        Me.packageCodeXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.packageCodeXrLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.packageCodeXrLabel.Location = New System.Drawing.Point(100, 300)
        Me.packageCodeXrLabel.Name = "packageCodeXrLabel"
        Me.packageCodeXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.packageCodeXrLabel.Size = New System.Drawing.Size(550, 50)
        Me.packageCodeXrLabel.StylePriority.UseBorders = False
        Me.packageCodeXrLabel.StylePriority.UseFont = False
        Me.packageCodeXrLabel.StylePriority.UseTextAlignment = False
        Me.packageCodeXrLabel.Text = "packageCodeXrLabel"
        Me.packageCodeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.Location = New System.Drawing.Point(0, 300)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(100, 50)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Package Code Format"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'layersPerPalletXrLabel
        '
        Me.layersPerPalletXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.layersPerPalletXrLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.layersPerPalletXrLabel.Location = New System.Drawing.Point(425, 250)
        Me.layersPerPalletXrLabel.Name = "layersPerPalletXrLabel"
        Me.layersPerPalletXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.layersPerPalletXrLabel.Size = New System.Drawing.Size(225, 50)
        Me.layersPerPalletXrLabel.StylePriority.UseBorders = False
        Me.layersPerPalletXrLabel.StylePriority.UseFont = False
        Me.layersPerPalletXrLabel.StylePriority.UseTextAlignment = False
        Me.layersPerPalletXrLabel.Text = "layersPerPalletXrLabel"
        Me.layersPerPalletXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.Location = New System.Drawing.Point(292, 250)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.Size = New System.Drawing.Size(133, 50)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Layers Per Pallet"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'casesPerLayerXrLabel
        '
        Me.casesPerLayerXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.casesPerLayerXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.casesPerLayerXrLabel.Location = New System.Drawing.Point(225, 250)
        Me.casesPerLayerXrLabel.Name = "casesPerLayerXrLabel"
        Me.casesPerLayerXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.casesPerLayerXrLabel.Size = New System.Drawing.Size(67, 50)
        Me.casesPerLayerXrLabel.StylePriority.UseBorders = False
        Me.casesPerLayerXrLabel.StylePriority.UseFont = False
        Me.casesPerLayerXrLabel.StylePriority.UseTextAlignment = False
        Me.casesPerLayerXrLabel.Text = "casesPerLayerXrLabel"
        Me.casesPerLayerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.Location = New System.Drawing.Point(0, 250)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(225, 50)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Cases Per Layer"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'casesPerPalletXrLabel
        '
        Me.casesPerPalletXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.casesPerPalletXrLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.casesPerPalletXrLabel.Location = New System.Drawing.Point(425, 200)
        Me.casesPerPalletXrLabel.Name = "casesPerPalletXrLabel"
        Me.casesPerPalletXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.casesPerPalletXrLabel.Size = New System.Drawing.Size(225, 50)
        Me.casesPerPalletXrLabel.StylePriority.UseBorders = False
        Me.casesPerPalletXrLabel.StylePriority.UseFont = False
        Me.casesPerPalletXrLabel.StylePriority.UseTextAlignment = False
        Me.casesPerPalletXrLabel.Text = "casesPerPalletXrLabel"
        Me.casesPerPalletXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.Location = New System.Drawing.Point(292, 200)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(133, 50)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Cases Per Pallet"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'unitsPerCaseXrLabel
        '
        Me.unitsPerCaseXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.unitsPerCaseXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.unitsPerCaseXrLabel.Location = New System.Drawing.Point(225, 200)
        Me.unitsPerCaseXrLabel.Name = "unitsPerCaseXrLabel"
        Me.unitsPerCaseXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.unitsPerCaseXrLabel.Size = New System.Drawing.Size(67, 50)
        Me.unitsPerCaseXrLabel.StylePriority.UseBorders = False
        Me.unitsPerCaseXrLabel.StylePriority.UseFont = False
        Me.unitsPerCaseXrLabel.StylePriority.UseTextAlignment = False
        Me.unitsPerCaseXrLabel.Text = "unitsPerCaseXrLabel"
        Me.unitsPerCaseXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.Location = New System.Drawing.Point(0, 200)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(225, 50)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Units Per Case"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'mavXrLabel
        '
        Me.mavXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.mavXrLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.mavXrLabel.Location = New System.Drawing.Point(492, 150)
        Me.mavXrLabel.Name = "mavXrLabel"
        Me.mavXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.mavXrLabel.Size = New System.Drawing.Size(158, 50)
        Me.mavXrLabel.StylePriority.UseBorders = False
        Me.mavXrLabel.StylePriority.UseFont = False
        Me.mavXrLabel.StylePriority.UseTextAlignment = False
        Me.mavXrLabel.Text = "mavXrLabel"
        Me.mavXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.Location = New System.Drawing.Point(292, 150)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(200, 50)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Maximum Allowance Variance (MAV)"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'requiredWeightXrLabel
        '
        Me.requiredWeightXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.requiredWeightXrLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.requiredWeightXrLabel.Location = New System.Drawing.Point(167, 150)
        Me.requiredWeightXrLabel.Name = "requiredWeightXrLabel"
        Me.requiredWeightXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.requiredWeightXrLabel.Size = New System.Drawing.Size(125, 50)
        Me.requiredWeightXrLabel.StylePriority.UseBorders = False
        Me.requiredWeightXrLabel.StylePriority.UseFont = False
        Me.requiredWeightXrLabel.StylePriority.UseTextAlignment = False
        Me.requiredWeightXrLabel.Text = "requiredWeightXrLabel"
        Me.requiredWeightXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.Location = New System.Drawing.Point(0, 150)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(167, 50)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Required Wsight/Count"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'itemBomsXrLabel
        '
        Me.itemBomsXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.itemBomsXrLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.itemBomsXrLabel.Location = New System.Drawing.Point(167, 100)
        Me.itemBomsXrLabel.Name = "itemBomsXrLabel"
        Me.itemBomsXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemBomsXrLabel.Size = New System.Drawing.Size(483, 50)
        Me.itemBomsXrLabel.StylePriority.UseBorders = False
        Me.itemBomsXrLabel.StylePriority.UseFont = False
        Me.itemBomsXrLabel.StylePriority.UseTextAlignment = False
        Me.itemBomsXrLabel.Text = "itemBomsXrLabel"
        Me.itemBomsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.Location = New System.Drawing.Point(0, 100)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(167, 50)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Raw Material Component Numbers"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPanel1
        '
        Me.XrPanel1.BackColor = System.Drawing.Color.Black
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.itemDescriptionXrLabel, Me.itemCodeXrLabel, Me.XrLabel1})
        Me.XrPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.Size = New System.Drawing.Size(650, 100)
        Me.XrPanel1.StylePriority.UseBackColor = False
        '
        'itemDescriptionXrLabel
        '
        Me.itemDescriptionXrLabel.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.itemDescriptionXrLabel.ForeColor = System.Drawing.Color.White
        Me.itemDescriptionXrLabel.Location = New System.Drawing.Point(0, 67)
        Me.itemDescriptionXrLabel.Name = "itemDescriptionXrLabel"
        Me.itemDescriptionXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemDescriptionXrLabel.Size = New System.Drawing.Size(650, 33)
        Me.itemDescriptionXrLabel.StylePriority.UseFont = False
        Me.itemDescriptionXrLabel.StylePriority.UseForeColor = False
        Me.itemDescriptionXrLabel.StylePriority.UseTextAlignment = False
        Me.itemDescriptionXrLabel.Text = "itemDescriptionXrLabel"
        Me.itemDescriptionXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'itemCodeXrLabel
        '
        Me.itemCodeXrLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.itemCodeXrLabel.ForeColor = System.Drawing.Color.White
        Me.itemCodeXrLabel.Location = New System.Drawing.Point(0, 33)
        Me.itemCodeXrLabel.Name = "itemCodeXrLabel"
        Me.itemCodeXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemCodeXrLabel.Size = New System.Drawing.Size(650, 33)
        Me.itemCodeXrLabel.StylePriority.UseFont = False
        Me.itemCodeXrLabel.StylePriority.UseForeColor = False
        Me.itemCodeXrLabel.StylePriority.UseTextAlignment = False
        Me.itemCodeXrLabel.Text = "itemCodeXrLabel"
        Me.itemCodeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Underline)
        Me.XrLabel1.ForeColor = System.Drawing.Color.White
        Me.XrLabel1.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(650, 33)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Produt Specifications"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ProductSpecificationsXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
        Me.Margins = New System.Drawing.Printing.Margins(90, 100, 100, 100)
        Me.Version = "8.3"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemDescriptionXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemCodeXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemBomsXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents requiredWeightXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents unitsPerCaseXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents mavXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents layersPerPalletXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents casesPerLayerXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents casesPerPalletXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents packageCodeXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrPanel3 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents shelfLifeXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents caseCodeXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents palletPaternXrPictureBox As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents specialInstructionsXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
End Class
