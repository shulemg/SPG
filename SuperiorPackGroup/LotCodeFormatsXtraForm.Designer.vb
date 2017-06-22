<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LotCodeFormatsXtraForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
            If m_LotCodeSession IsNot Nothing Then
                m_LotCodeSession.Dispose()
                m_LotCodeSession = Nothing
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LotCodeFormatsXtraForm))
        Me.lotCodeSectionSettingsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSettingName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSettingValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lotCodeSectionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lotCodeFormatSectionsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.lotCodeFormatSectionsXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.lotCodeFormatSectionsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lotCodeFormatGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSectionName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSectionType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSectionLength = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSectionPosition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lotCodeFormatIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lotCodeSettingsGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.lotCodeFormatPreviewGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.sectionSettingsPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.changePositionSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.deleteSettingsSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.cancelSettingsChangesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.toSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.fromSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.restartsOnTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.firstDayOfWeekImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.firstWeekOfYearImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.firstYearTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.replacementLettersTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lettersToReplaceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.lettersToSkipTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.saveSettingsSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.editSettingsSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.sectionPositionSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.sectionLengthSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.sectionTypeImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.sectionNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.firstMonthComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cancelFormatChangesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.editLotCodeFormatSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.newLotCodeFormatSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.deleteFormatSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.saveFormatSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.formatWarningLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.formatSectionsSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.formatNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.lotCodeSectionSettingsGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lotCodeFormatSectionsGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lotCodeFormatSectionsXpCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lotCodeFormatSectionsGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lotCodeSettingsGroupControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.lotCodeSettingsGroupControl.SuspendLayout
        CType(Me.lotCodeFormatPreviewGroupControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sectionSettingsPanelControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.sectionSettingsPanelControl.SuspendLayout
        CType(Me.toSpinEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.fromSpinEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.restartsOnTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.firstDayOfWeekImageComboBoxEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.firstWeekOfYearImageComboBoxEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.firstYearTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.replacementLettersTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lettersToReplaceTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lettersToSkipTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sectionPositionSpinEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sectionLengthSpinEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sectionTypeImageComboBoxEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sectionNameTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.firstMonthComboBoxEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
        CType(Me.formatSectionsSpinEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.formatNameTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lotCodeSectionSettingsGridView
        '
        Me.lotCodeSectionSettingsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSettingName, Me.colSettingValue, Me.lotCodeSectionGridColumn})
        Me.lotCodeSectionSettingsGridView.GridControl = Me.lotCodeFormatSectionsGridControl
        Me.lotCodeSectionSettingsGridView.Name = "lotCodeSectionSettingsGridView"
        '
        'colSettingName
        '
        Me.colSettingName.FieldName = "SettingName"
        Me.colSettingName.Name = "colSettingName"
        Me.colSettingName.Visible = true
        Me.colSettingName.VisibleIndex = 0
        '
        'colSettingValue
        '
        Me.colSettingValue.FieldName = "SettingValue"
        Me.colSettingValue.Name = "colSettingValue"
        Me.colSettingValue.Visible = true
        Me.colSettingValue.VisibleIndex = 1
        '
        'lotCodeSectionGridColumn
        '
        Me.lotCodeSectionGridColumn.FieldName = "LotCodeSection!"
        Me.lotCodeSectionGridColumn.Name = "lotCodeSectionGridColumn"
        '
        'lotCodeFormatSectionsGridControl
        '
        Me.lotCodeFormatSectionsGridControl.DataSource = Me.lotCodeFormatSectionsXpCollection
        GridLevelNode1.LevelTemplate = Me.lotCodeSectionSettingsGridView
        GridLevelNode1.RelationName = "SectionSettings"
        Me.lotCodeFormatSectionsGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.lotCodeFormatSectionsGridControl.Location = New System.Drawing.Point(13, 339)
        Me.lotCodeFormatSectionsGridControl.MainView = Me.lotCodeFormatSectionsGridView
        Me.lotCodeFormatSectionsGridControl.Name = "lotCodeFormatSectionsGridControl"
        Me.lotCodeFormatSectionsGridControl.ShowOnlyPredefinedDetails = true
        Me.lotCodeFormatSectionsGridControl.Size = New System.Drawing.Size(1109, 290)
        Me.lotCodeFormatSectionsGridControl.TabIndex = 2
        Me.lotCodeFormatSectionsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lotCodeFormatSectionsGridView, Me.lotCodeSectionSettingsGridView})
        '
        'lotCodeFormatSectionsXpCollection
        '
        Me.lotCodeFormatSectionsXpCollection.ObjectType = GetType(DXDAL.SPGData.LotCodeFormatSections)
        '
        'lotCodeFormatSectionsGridView
        '
        Me.lotCodeFormatSectionsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.lotCodeFormatGridColumn, Me.colSectionName, Me.colSectionType, Me.colSectionLength, Me.colSectionPosition, Me.lotCodeFormatIDGridColumn})
        Me.lotCodeFormatSectionsGridView.GridControl = Me.lotCodeFormatSectionsGridControl
        Me.lotCodeFormatSectionsGridView.GroupCount = 1
        Me.lotCodeFormatSectionsGridView.Name = "lotCodeFormatSectionsGridView"
        Me.lotCodeFormatSectionsGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.lotCodeFormatGridColumn, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'lotCodeFormatGridColumn
        '
        Me.lotCodeFormatGridColumn.Caption = "Lot Code Format"
        Me.lotCodeFormatGridColumn.FieldName = "LotCodeFormat.FormatName"
        Me.lotCodeFormatGridColumn.Name = "lotCodeFormatGridColumn"
        Me.lotCodeFormatGridColumn.Visible = true
        Me.lotCodeFormatGridColumn.VisibleIndex = 0
        '
        'colSectionName
        '
        Me.colSectionName.FieldName = "SectionName"
        Me.colSectionName.Name = "colSectionName"
        Me.colSectionName.Visible = true
        Me.colSectionName.VisibleIndex = 0
        '
        'colSectionType
        '
        Me.colSectionType.FieldName = "SectionType"
        Me.colSectionType.Name = "colSectionType"
        Me.colSectionType.Visible = true
        Me.colSectionType.VisibleIndex = 1
        '
        'colSectionLength
        '
        Me.colSectionLength.FieldName = "SectionLength"
        Me.colSectionLength.Name = "colSectionLength"
        Me.colSectionLength.Visible = true
        Me.colSectionLength.VisibleIndex = 2
        '
        'colSectionPosition
        '
        Me.colSectionPosition.FieldName = "SectionPosition"
        Me.colSectionPosition.Name = "colSectionPosition"
        Me.colSectionPosition.Visible = true
        Me.colSectionPosition.VisibleIndex = 3
        '
        'lotCodeFormatIDGridColumn
        '
        Me.lotCodeFormatIDGridColumn.FieldName = "LotCodeFormat!Key"
        Me.lotCodeFormatIDGridColumn.Name = "lotCodeFormatIDGridColumn"
        Me.lotCodeFormatIDGridColumn.Visible = true
        Me.lotCodeFormatIDGridColumn.VisibleIndex = 4
        '
        'lotCodeSettingsGroupControl
        '
        Me.lotCodeSettingsGroupControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lotCodeSettingsGroupControl.Controls.Add(Me.lotCodeFormatPreviewGroupControl)
        Me.lotCodeSettingsGroupControl.Controls.Add(Me.sectionSettingsPanelControl)
        Me.lotCodeSettingsGroupControl.Controls.Add(Me.PanelControl1)
        Me.lotCodeSettingsGroupControl.Location = New System.Drawing.Point(12, 12)
        Me.lotCodeSettingsGroupControl.Name = "lotCodeSettingsGroupControl"
        Me.lotCodeSettingsGroupControl.Size = New System.Drawing.Size(1110, 321)
        Me.lotCodeSettingsGroupControl.TabIndex = 0
        Me.lotCodeSettingsGroupControl.Text = "Lot Code Format Settings"
        '
        'lotCodeFormatPreviewGroupControl
        '
        Me.lotCodeFormatPreviewGroupControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lotCodeFormatPreviewGroupControl.Location = New System.Drawing.Point(212, 215)
        Me.lotCodeFormatPreviewGroupControl.Name = "lotCodeFormatPreviewGroupControl"
        Me.lotCodeFormatPreviewGroupControl.Size = New System.Drawing.Size(893, 100)
        Me.lotCodeFormatPreviewGroupControl.TabIndex = 2
        Me.lotCodeFormatPreviewGroupControl.Text = "Lot Code Format Preview"
        '
        'sectionSettingsPanelControl
        '
        Me.sectionSettingsPanelControl.Controls.Add(Me.changePositionSimpleButton)
        Me.sectionSettingsPanelControl.Controls.Add(Me.deleteSettingsSimpleButton)
        Me.sectionSettingsPanelControl.Controls.Add(Me.cancelSettingsChangesSimpleButton)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl18)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl17)
        Me.sectionSettingsPanelControl.Controls.Add(Me.toSpinEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.fromSpinEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl16)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl15)
        Me.sectionSettingsPanelControl.Controls.Add(Me.restartsOnTextEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl14)
        Me.sectionSettingsPanelControl.Controls.Add(Me.firstDayOfWeekImageComboBoxEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl13)
        Me.sectionSettingsPanelControl.Controls.Add(Me.firstWeekOfYearImageComboBoxEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.firstYearTextEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl12)
        Me.sectionSettingsPanelControl.Controls.Add(Me.replacementLettersTextEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl11)
        Me.sectionSettingsPanelControl.Controls.Add(Me.lettersToReplaceTextEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl10)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl9)
        Me.sectionSettingsPanelControl.Controls.Add(Me.lettersToSkipTextEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl8)
        Me.sectionSettingsPanelControl.Controls.Add(Me.saveSettingsSimpleButton)
        Me.sectionSettingsPanelControl.Controls.Add(Me.editSettingsSimpleButton)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl7)
        Me.sectionSettingsPanelControl.Controls.Add(Me.sectionPositionSpinEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.sectionLengthSpinEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl6)
        Me.sectionSettingsPanelControl.Controls.Add(Me.sectionTypeImageComboBoxEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl5)
        Me.sectionSettingsPanelControl.Controls.Add(Me.sectionNameTextEdit)
        Me.sectionSettingsPanelControl.Controls.Add(Me.LabelControl4)
        Me.sectionSettingsPanelControl.Controls.Add(Me.firstMonthComboBoxEdit)
        Me.sectionSettingsPanelControl.Location = New System.Drawing.Point(212, 24)
        Me.sectionSettingsPanelControl.Name = "sectionSettingsPanelControl"
        Me.sectionSettingsPanelControl.Size = New System.Drawing.Size(893, 185)
        Me.sectionSettingsPanelControl.TabIndex = 1
        '
        'changePositionSimpleButton
        '
        Me.changePositionSimpleButton.Appearance.Options.UseTextOptions = true
        Me.changePositionSimpleButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.changePositionSimpleButton.Location = New System.Drawing.Point(54, 130)
        Me.changePositionSimpleButton.Name = "changePositionSimpleButton"
        Me.changePositionSimpleButton.Size = New System.Drawing.Size(85, 50)
        Me.changePositionSimpleButton.TabIndex = 34
        Me.changePositionSimpleButton.Text = "Change Position"
        '
        'deleteSettingsSimpleButton
        '
        Me.deleteSettingsSimpleButton.Appearance.Options.UseTextOptions = true
        Me.deleteSettingsSimpleButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.deleteSettingsSimpleButton.Location = New System.Drawing.Point(418, 130)
        Me.deleteSettingsSimpleButton.Name = "deleteSettingsSimpleButton"
        Me.deleteSettingsSimpleButton.Size = New System.Drawing.Size(85, 50)
        Me.deleteSettingsSimpleButton.TabIndex = 33
        Me.deleteSettingsSimpleButton.Text = "Delete Section Settings"
        '
        'cancelSettingsChangesSimpleButton
        '
        Me.cancelSettingsChangesSimpleButton.Appearance.Options.UseTextOptions = true
        Me.cancelSettingsChangesSimpleButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cancelSettingsChangesSimpleButton.Location = New System.Drawing.Point(327, 130)
        Me.cancelSettingsChangesSimpleButton.Name = "cancelSettingsChangesSimpleButton"
        Me.cancelSettingsChangesSimpleButton.Size = New System.Drawing.Size(85, 50)
        Me.cancelSettingsChangesSimpleButton.TabIndex = 32
        Me.cancelSettingsChangesSimpleButton.Text = "Cancel Changes"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(562, 16)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl18.TabIndex = 30
        Me.LabelControl18.Text = "First Month"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(734, 145)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(10, 13)
        Me.LabelControl17.TabIndex = 29
        Me.LabelControl17.Text = "to"
        '
        'toSpinEdit
        '
        Me.toSpinEdit.EditValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.toSpinEdit.Location = New System.Drawing.Point(750, 142)
        Me.toSpinEdit.Name = "toSpinEdit"
        Me.toSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.toSpinEdit.Size = New System.Drawing.Size(72, 20)
        Me.toSpinEdit.TabIndex = 28
        '
        'fromSpinEdit
        '
        Me.fromSpinEdit.EditValue = New Decimal(New Integer() {11, 0, 0, 0})
        Me.fromSpinEdit.Location = New System.Drawing.Point(657, 142)
        Me.fromSpinEdit.Name = "fromSpinEdit"
        Me.fromSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fromSpinEdit.Size = New System.Drawing.Size(71, 20)
        Me.fromSpinEdit.TabIndex = 27
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(562, 145)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl16.TabIndex = 26
        Me.LabelControl16.Text = "Number Range"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(562, 118)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl15.TabIndex = 25
        Me.LabelControl15.Text = "Restarts On the"
        '
        'restartsOnTextEdit
        '
        Me.restartsOnTextEdit.Location = New System.Drawing.Point(657, 115)
        Me.restartsOnTextEdit.Name = "restartsOnTextEdit"
        Me.restartsOnTextEdit.Size = New System.Drawing.Size(165, 20)
        Me.restartsOnTextEdit.TabIndex = 24
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(562, 92)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl14.TabIndex = 23
        Me.LabelControl14.Text = "First Day of Week"
        '
        'firstDayOfWeekImageComboBoxEdit
        '
        Me.firstDayOfWeekImageComboBoxEdit.Location = New System.Drawing.Point(657, 89)
        Me.firstDayOfWeekImageComboBoxEdit.Name = "firstDayOfWeekImageComboBoxEdit"
        Me.firstDayOfWeekImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.firstDayOfWeekImageComboBoxEdit.Size = New System.Drawing.Size(165, 20)
        Me.firstDayOfWeekImageComboBoxEdit.TabIndex = 22
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(562, 68)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl13.TabIndex = 21
        Me.LabelControl13.Text = "First Week of Year"
        '
        'firstWeekOfYearImageComboBoxEdit
        '
        Me.firstWeekOfYearImageComboBoxEdit.Location = New System.Drawing.Point(657, 65)
        Me.firstWeekOfYearImageComboBoxEdit.Name = "firstWeekOfYearImageComboBoxEdit"
        Me.firstWeekOfYearImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.firstWeekOfYearImageComboBoxEdit.Size = New System.Drawing.Size(165, 20)
        Me.firstWeekOfYearImageComboBoxEdit.TabIndex = 20
        '
        'firstYearTextEdit
        '
        Me.firstYearTextEdit.Location = New System.Drawing.Point(657, 39)
        Me.firstYearTextEdit.Name = "firstYearTextEdit"
        Me.firstYearTextEdit.Size = New System.Drawing.Size(165, 20)
        Me.firstYearTextEdit.TabIndex = 19
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(562, 40)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl12.TabIndex = 18
        Me.LabelControl12.Text = "First Year"
        '
        'replacementLettersTextEdit
        '
        Me.replacementLettersTextEdit.Location = New System.Drawing.Point(363, 96)
        Me.replacementLettersTextEdit.Name = "replacementLettersTextEdit"
        Me.replacementLettersTextEdit.Size = New System.Drawing.Size(183, 20)
        Me.replacementLettersTextEdit.TabIndex = 17
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(258, 99)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl11.TabIndex = 16
        Me.LabelControl11.Text = "Replacement Letters"
        '
        'lettersToReplaceTextEdit
        '
        Me.lettersToReplaceTextEdit.Location = New System.Drawing.Point(363, 70)
        Me.lettersToReplaceTextEdit.Name = "lettersToReplaceTextEdit"
        Me.lettersToReplaceTextEdit.Size = New System.Drawing.Size(183, 20)
        Me.lettersToReplaceTextEdit.TabIndex = 15
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(258, 73)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl10.TabIndex = 14
        Me.LabelControl10.Text = "Letters to Replace"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(258, 12)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(288, 26)
        Me.LabelControl9.TabIndex = 13
        Me.LabelControl9.Text = "Enter a list of letters separated with a comma, the letters to "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"replace and repl"& _ 
    "acement letters should be in the same order"
        '
        'lettersToSkipTextEdit
        '
        Me.lettersToSkipTextEdit.Location = New System.Drawing.Point(363, 44)
        Me.lettersToSkipTextEdit.Name = "lettersToSkipTextEdit"
        Me.lettersToSkipTextEdit.Size = New System.Drawing.Size(183, 20)
        Me.lettersToSkipTextEdit.TabIndex = 12
        Me.lettersToSkipTextEdit.ToolTip = "Enter the letters separated with a comma"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(258, 49)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl8.TabIndex = 11
        Me.LabelControl8.Text = "Letters to Skip"
        '
        'saveSettingsSimpleButton
        '
        Me.saveSettingsSimpleButton.Appearance.Options.UseTextOptions = true
        Me.saveSettingsSimpleButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.saveSettingsSimpleButton.Location = New System.Drawing.Point(236, 130)
        Me.saveSettingsSimpleButton.Name = "saveSettingsSimpleButton"
        Me.saveSettingsSimpleButton.Size = New System.Drawing.Size(85, 50)
        Me.saveSettingsSimpleButton.TabIndex = 9
        Me.saveSettingsSimpleButton.Text = "Save Section Settings"
        '
        'editSettingsSimpleButton
        '
        Me.editSettingsSimpleButton.Appearance.Options.UseTextOptions = true
        Me.editSettingsSimpleButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.editSettingsSimpleButton.Location = New System.Drawing.Point(145, 130)
        Me.editSettingsSimpleButton.Name = "editSettingsSimpleButton"
        Me.editSettingsSimpleButton.Size = New System.Drawing.Size(85, 50)
        Me.editSettingsSimpleButton.TabIndex = 8
        Me.editSettingsSimpleButton.Text = "Edit Section Settings"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(21, 21)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl7.TabIndex = 7
        Me.LabelControl7.Text = "Section Position"
        '
        'sectionPositionSpinEdit
        '
        Me.sectionPositionSpinEdit.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sectionPositionSpinEdit.Location = New System.Drawing.Point(102, 18)
        Me.sectionPositionSpinEdit.Name = "sectionPositionSpinEdit"
        Me.sectionPositionSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sectionPositionSpinEdit.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.sectionPositionSpinEdit.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sectionPositionSpinEdit.Size = New System.Drawing.Size(149, 20)
        Me.sectionPositionSpinEdit.TabIndex = 6
        '
        'sectionLengthSpinEdit
        '
        Me.sectionLengthSpinEdit.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sectionLengthSpinEdit.Location = New System.Drawing.Point(102, 96)
        Me.sectionLengthSpinEdit.Name = "sectionLengthSpinEdit"
        Me.sectionLengthSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sectionLengthSpinEdit.Properties.MaxValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.sectionLengthSpinEdit.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sectionLengthSpinEdit.Size = New System.Drawing.Size(149, 20)
        Me.sectionLengthSpinEdit.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(21, 99)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "Section Length"
        '
        'sectionTypeImageComboBoxEdit
        '
        Me.sectionTypeImageComboBoxEdit.Location = New System.Drawing.Point(102, 70)
        Me.sectionTypeImageComboBoxEdit.Name = "sectionTypeImageComboBoxEdit"
        Me.sectionTypeImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sectionTypeImageComboBoxEdit.Size = New System.Drawing.Size(149, 20)
        Me.sectionTypeImageComboBoxEdit.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(21, 73)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl5.TabIndex = 2
        Me.LabelControl5.Text = "Section Type"
        '
        'sectionNameTextEdit
        '
        Me.sectionNameTextEdit.Location = New System.Drawing.Point(102, 44)
        Me.sectionNameTextEdit.Name = "sectionNameTextEdit"
        Me.sectionNameTextEdit.Size = New System.Drawing.Size(149, 20)
        Me.sectionNameTextEdit.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(21, 47)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Section Name"
        '
        'firstMonthComboBoxEdit
        '
        Me.firstMonthComboBoxEdit.Location = New System.Drawing.Point(657, 13)
        Me.firstMonthComboBoxEdit.Name = "firstMonthComboBoxEdit"
        Me.firstMonthComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.firstMonthComboBoxEdit.Properties.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.firstMonthComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.firstMonthComboBoxEdit.Size = New System.Drawing.Size(165, 20)
        Me.firstMonthComboBoxEdit.TabIndex = 31
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cancelFormatChangesSimpleButton)
        Me.PanelControl1.Controls.Add(Me.editLotCodeFormatSimpleButton)
        Me.PanelControl1.Controls.Add(Me.newLotCodeFormatSimpleButton)
        Me.PanelControl1.Controls.Add(Me.deleteFormatSimpleButton)
        Me.PanelControl1.Controls.Add(Me.saveFormatSimpleButton)
        Me.PanelControl1.Controls.Add(Me.formatWarningLabelControl)
        Me.PanelControl1.Controls.Add(Me.formatSectionsSpinEdit)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.formatNameTextEdit)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 23)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(200, 292)
        Me.PanelControl1.TabIndex = 0
        '
        'cancelFormatChangesSimpleButton
        '
        Me.cancelFormatChangesSimpleButton.Location = New System.Drawing.Point(32, 235)
        Me.cancelFormatChangesSimpleButton.Name = "cancelFormatChangesSimpleButton"
        Me.cancelFormatChangesSimpleButton.Size = New System.Drawing.Size(130, 23)
        Me.cancelFormatChangesSimpleButton.TabIndex = 9
        Me.cancelFormatChangesSimpleButton.Text = "Cancel Changes"
        '
        'editLotCodeFormatSimpleButton
        '
        Me.editLotCodeFormatSimpleButton.Location = New System.Drawing.Point(32, 176)
        Me.editLotCodeFormatSimpleButton.Name = "editLotCodeFormatSimpleButton"
        Me.editLotCodeFormatSimpleButton.Size = New System.Drawing.Size(130, 23)
        Me.editLotCodeFormatSimpleButton.TabIndex = 8
        Me.editLotCodeFormatSimpleButton.Text = "Edit Lot Code Format"
        '
        'newLotCodeFormatSimpleButton
        '
        Me.newLotCodeFormatSimpleButton.Location = New System.Drawing.Point(32, 147)
        Me.newLotCodeFormatSimpleButton.Name = "newLotCodeFormatSimpleButton"
        Me.newLotCodeFormatSimpleButton.Size = New System.Drawing.Size(130, 23)
        Me.newLotCodeFormatSimpleButton.TabIndex = 7
        Me.newLotCodeFormatSimpleButton.Text = "New Lot Code Format"
        '
        'deleteFormatSimpleButton
        '
        Me.deleteFormatSimpleButton.Location = New System.Drawing.Point(32, 264)
        Me.deleteFormatSimpleButton.Name = "deleteFormatSimpleButton"
        Me.deleteFormatSimpleButton.Size = New System.Drawing.Size(130, 23)
        Me.deleteFormatSimpleButton.TabIndex = 6
        Me.deleteFormatSimpleButton.Text = "Delete Lot Code Format"
        '
        'saveFormatSimpleButton
        '
        Me.saveFormatSimpleButton.Location = New System.Drawing.Point(32, 205)
        Me.saveFormatSimpleButton.Name = "saveFormatSimpleButton"
        Me.saveFormatSimpleButton.Size = New System.Drawing.Size(130, 23)
        Me.saveFormatSimpleButton.TabIndex = 5
        Me.saveFormatSimpleButton.Text = "Save Lot Code Format"
        '
        'formatWarningLabelControl
        '
        Me.formatWarningLabelControl.Appearance.BackColor = System.Drawing.Color.Red
        Me.formatWarningLabelControl.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.formatWarningLabelControl.Appearance.ForeColor = System.Drawing.Color.White
        Me.formatWarningLabelControl.Location = New System.Drawing.Point(32, 128)
        Me.formatWarningLabelControl.Name = "formatWarningLabelControl"
        Me.formatWarningLabelControl.Size = New System.Drawing.Size(137, 13)
        Me.formatWarningLabelControl.TabIndex = 4
        Me.formatWarningLabelControl.Text = "Missing Section Settings"
        '
        'formatSectionsSpinEdit
        '
        Me.formatSectionsSpinEdit.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.formatSectionsSpinEdit.Location = New System.Drawing.Point(50, 101)
        Me.formatSectionsSpinEdit.Name = "formatSectionsSpinEdit"
        Me.formatSectionsSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.formatSectionsSpinEdit.Properties.MaxValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.formatSectionsSpinEdit.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.formatSectionsSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.formatSectionsSpinEdit.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(39, 81)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Lot Code Format Sections"
        '
        'formatNameTextEdit
        '
        Me.formatNameTextEdit.Location = New System.Drawing.Point(5, 54)
        Me.formatNameTextEdit.Name = "formatNameTextEdit"
        Me.formatNameTextEdit.Size = New System.Drawing.Size(190, 20)
        Me.formatNameTextEdit.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(45, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Lot Code Format Name"
        '
        'LotCodeFormatsXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 641)
        Me.Controls.Add(Me.lotCodeFormatSectionsGridControl)
        Me.Controls.Add(Me.lotCodeSettingsGroupControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "LotCodeFormatsXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lot Code Formats"
        CType(Me.lotCodeSectionSettingsGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lotCodeFormatSectionsGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lotCodeFormatSectionsXpCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lotCodeFormatSectionsGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lotCodeSettingsGroupControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.lotCodeSettingsGroupControl.ResumeLayout(false)
        CType(Me.lotCodeFormatPreviewGroupControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sectionSettingsPanelControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.sectionSettingsPanelControl.ResumeLayout(false)
        Me.sectionSettingsPanelControl.PerformLayout
        CType(Me.toSpinEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fromSpinEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.restartsOnTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.firstDayOfWeekImageComboBoxEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.firstWeekOfYearImageComboBoxEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.firstYearTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.replacementLettersTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lettersToReplaceTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lettersToSkipTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sectionPositionSpinEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sectionLengthSpinEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sectionTypeImageComboBoxEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sectionNameTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.firstMonthComboBoxEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(false)
        Me.PanelControl1.PerformLayout
        CType(Me.formatSectionsSpinEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.formatNameTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents lotCodeSettingsGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lotCodeFormatSectionsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents lotCodeSectionSettingsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lotCodeFormatSectionsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents formatNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents formatSectionsSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents formatWarningLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sectionSettingsPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents saveFormatSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sectionNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sectionTypeImageComboBoxEdit As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sectionLengthSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sectionPositionSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents saveSettingsSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents editSettingsSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lettersToSkipTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents replacementLettersTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lettersToReplaceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents firstYearTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents firstWeekOfYearImageComboBoxEdit As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents firstDayOfWeekImageComboBoxEdit As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents toSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents fromSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents restartsOnTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colSettingName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSettingValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lotCodeFormatSectionsXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lotCodeFormatGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSectionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSectionType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSectionLength As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSectionPosition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cancelSettingsChangesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deleteSettingsSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deleteFormatSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lotCodeFormatPreviewGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents newLotCodeFormatSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents editLotCodeFormatSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cancelFormatChangesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lotCodeFormatIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lotCodeSectionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents firstMonthComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents changePositionSimpleButton As DevExpress.XtraEditors.SimpleButton
End Class
