<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomAppointmentForm
    Inherits DevExpress.XtraScheduler.UI.AppointmentForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.peopleTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.operatorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.itemLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.itemsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.mustRunCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.itemDescriptionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.projectLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.projectsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.projectDetailLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.projectDetailXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.projectItemsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.quantityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.schedByQuantityCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.priorityComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.progressPanel.SuspendLayout()
        CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peopleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.operatorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemsXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mustRunCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemDescriptionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectsXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectDetailLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectDetailXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectItemsXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedByQuantityCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priorityComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSubject
        '
        Me.lblSubject.Location = New System.Drawing.Point(187, 270)
        Me.lblSubject.Visible = False
        '
        'lblLocation
        '
        Me.lblLocation.Location = New System.Drawing.Point(187, 296)
        Me.lblLocation.Visible = False
        '
        'lblLabel
        '
        Me.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblLabel.Location = New System.Drawing.Point(22, 101)
        Me.lblLabel.Visible = False
        '
        'lblStartTime
        '
        Me.lblStartTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStartTime.Location = New System.Drawing.Point(16, 125)
        '
        'lblEndTime
        '
        Me.lblEndTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEndTime.Location = New System.Drawing.Point(16, 150)
        '
        'lblShowTimeAs
        '
        Me.lblShowTimeAs.Location = New System.Drawing.Point(187, 283)
        '
        'chkAllDay
        '
        Me.chkAllDay.Location = New System.Drawing.Point(0, 103)
        Me.chkAllDay.Visible = False
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(16, 383)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(104, 383)
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(192, 383)
        '
        'btnRecurrence
        '
        Me.btnRecurrence.Location = New System.Drawing.Point(280, 383)
        Me.btnRecurrence.Visible = False
        '
        'edtStartDate
        '
        Me.edtStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.edtStartDate.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtStartDate.Location = New System.Drawing.Point(96, 122)
        '
        'edtEndDate
        '
        Me.edtEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.edtEndDate.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtEndDate.Location = New System.Drawing.Point(96, 147)
        '
        'edtStartTime
        '
        Me.edtStartTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.edtStartTime.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtStartTime.Location = New System.Drawing.Point(224, 123)
        Me.edtStartTime.Properties.Mask.EditMask = "t"
        '
        'edtEndTime
        '
        Me.edtEndTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.edtEndTime.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtEndTime.Location = New System.Drawing.Point(224, 147)
        Me.edtEndTime.Properties.Mask.EditMask = "t"
        '
        'edtLabel
        '
        Me.edtLabel.Location = New System.Drawing.Point(77, 98)
        Me.edtLabel.Visible = False
        '
        'edtShowTimeAs
        '
        Me.edtShowTimeAs.Location = New System.Drawing.Point(267, 209)
        '
        'tbSubject
        '
        Me.tbSubject.Location = New System.Drawing.Point(96, 319)
        Me.tbSubject.Visible = False
        '
        'edtResource
        '
        Me.edtResource.Location = New System.Drawing.Point(79, 1)
        '
        'lblResource
        '
        Me.lblResource.Location = New System.Drawing.Point(3, 7)
        Me.lblResource.Size = New System.Drawing.Size(65, 13)
        Me.lblResource.Text = "Machine Line:"
        '
        'edtResources
        '
        Me.edtResources.Location = New System.Drawing.Point(74, 4)
        '
        '
        '
        Me.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = True
        Me.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.edtResources.ResourcesCheckedListBoxControl.Location = New System.Drawing.Point(0, 0)
        Me.edtResources.ResourcesCheckedListBoxControl.Name = ""
        Me.edtResources.ResourcesCheckedListBoxControl.Size = New System.Drawing.Size(200, 100)
        Me.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0
        '
        'chkReminder
        '
        Me.chkReminder.Visible = False
        '
        'tbDescription
        '
        Me.tbDescription.Location = New System.Drawing.Point(16, 234)
        '
        'cbReminder
        '
        Me.cbReminder.Visible = False
        '
        'tbLocation
        '
        Me.tbLocation.Location = New System.Drawing.Point(267, 293)
        Me.tbLocation.Visible = False
        '
        'panel1
        '
        Me.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panel1.Location = New System.Drawing.Point(320, 43)
        Me.panel1.Size = New System.Drawing.Size(192, 24)
        '
        'progressPanel
        '
        Me.progressPanel.Location = New System.Drawing.Point(16, 253)
        Me.progressPanel.Visible = False
        '
        'tbProgress
        '
        Me.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = True
        Me.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tbProgress.Visible = False
        '
        'lblPercentComplete
        '
        Me.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent
        '
        'lblPercentCompleteValue
        '
        Me.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent
        '
        'peopleTextEdit
        '
        Me.peopleTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.peopleTextEdit.Location = New System.Drawing.Point(399, 70)
        Me.peopleTextEdit.Name = "peopleTextEdit"
        Me.peopleTextEdit.Size = New System.Drawing.Size(112, 20)
        Me.peopleTextEdit.TabIndex = 29
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl1.Location = New System.Drawing.Point(322, 73)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 30
        Me.LabelControl1.Text = "People:"
        '
        'operatorTextEdit
        '
        Me.operatorTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.operatorTextEdit.Location = New System.Drawing.Point(399, 96)
        Me.operatorTextEdit.Name = "operatorTextEdit"
        Me.operatorTextEdit.Size = New System.Drawing.Size(112, 20)
        Me.operatorTextEdit.TabIndex = 31
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl2.Location = New System.Drawing.Point(324, 99)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 32
        Me.LabelControl2.Text = "Operator:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl3.Location = New System.Drawing.Point(16, 50)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "Item:"
        '
        'itemLookUpEdit
        '
        Me.itemLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.itemLookUpEdit.Location = New System.Drawing.Point(96, 47)
        Me.itemLookUpEdit.Name = "itemLookUpEdit"
        Me.itemLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.itemLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 73, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemDescription", "Item Description", 88, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DefaultMachine", "Default Machine")})
        Me.itemLookUpEdit.Properties.DataSource = Me.itemsXpView
        Me.itemLookUpEdit.Properties.DisplayMember = "ItemCode"
        Me.itemLookUpEdit.Properties.ValueMember = "ItemID"
        Me.itemLookUpEdit.Size = New System.Drawing.Size(216, 20)
        Me.itemLookUpEdit.TabIndex = 34
        '
        'itemsXpView
        '
        Me.itemsXpView.CriteriaString = "[ItemType] <> 'RM'"
        Me.itemsXpView.ObjectType = GetType(DXDAL.SPGData.Items)
        Me.itemsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Descending, "[ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[ItemDescription]", False, True), New DevExpress.Xpo.ViewProperty("DefaultMachine", DevExpress.Xpo.SortDirection.None, "[ItemDefaultMachine.MachineLineName]", False, True), New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", False, True)})
        '
        'mustRunCheckEdit
        '
        Me.mustRunCheckEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.mustRunCheckEdit.Location = New System.Drawing.Point(415, 174)
        Me.mustRunCheckEdit.Name = "mustRunCheckEdit"
        Me.mustRunCheckEdit.Properties.Caption = "Must run:"
        Me.mustRunCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.mustRunCheckEdit.Size = New System.Drawing.Size(96, 19)
        Me.mustRunCheckEdit.TabIndex = 35
        '
        'itemDescriptionMemoEdit
        '
        Me.itemDescriptionMemoEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.itemDescriptionMemoEdit.Location = New System.Drawing.Point(96, 74)
        Me.itemDescriptionMemoEdit.Name = "itemDescriptionMemoEdit"
        Me.itemDescriptionMemoEdit.Size = New System.Drawing.Size(216, 42)
        Me.itemDescriptionMemoEdit.TabIndex = 36
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl4.Location = New System.Drawing.Point(16, 24)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl4.TabIndex = 37
        Me.LabelControl4.Text = "Project:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl5.Location = New System.Drawing.Point(326, 24)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl5.TabIndex = 38
        Me.LabelControl5.Text = "Customer PO:"
        '
        'projectLookUpEdit
        '
        Me.projectLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.projectLookUpEdit.Location = New System.Drawing.Point(96, 21)
        Me.projectLookUpEdit.Name = "projectLookUpEdit"
        Me.projectLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.projectLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProjectID", "Project ID", 71, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Project", "Project", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.projectLookUpEdit.Properties.DataSource = Me.projectsXpView
        Me.projectLookUpEdit.Properties.DisplayMember = "Project"
        Me.projectLookUpEdit.Properties.ValueMember = "ProjectID"
        Me.projectLookUpEdit.Size = New System.Drawing.Size(216, 20)
        Me.projectLookUpEdit.TabIndex = 39
        '
        'projectsXpView
        '
        Me.projectsXpView.CriteriaString = "[ProjectStatus] <> 3L"
        Me.projectsXpView.ObjectType = GetType(DXDAL.SPGData.Project)
        Me.projectsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ProjectID", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True), New DevExpress.Xpo.ViewProperty("Project", DevExpress.Xpo.SortDirection.None, "[Project]", False, True)})
        '
        'projectDetailLookUpEdit
        '
        Me.projectDetailLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.projectDetailLookUpEdit.Location = New System.Drawing.Point(399, 21)
        Me.projectDetailLookUpEdit.Name = "projectDetailLookUpEdit"
        Me.projectDetailLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.projectDetailLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Project", "Project", 57, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProjectDtail", "Project Dtail", 68, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerPO", "Customer PO", 73, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Item Code", "Item Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BagsNeeded", "Bags Needed", 81, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProjectItemID", "ProjectItemID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.projectDetailLookUpEdit.Properties.DataSource = Me.projectDetailXpView
        Me.projectDetailLookUpEdit.Properties.DisplayMember = "CustomerPO"
        Me.projectDetailLookUpEdit.Properties.ValueMember = "ProjectDtail"
        Me.projectDetailLookUpEdit.Size = New System.Drawing.Size(112, 20)
        Me.projectDetailLookUpEdit.TabIndex = 40
        '
        'projectDetailXpView
        '
        Me.projectDetailXpView.CriteriaString = "[Project] Is Null"
        Me.projectDetailXpView.ObjectType = GetType(DXDAL.SPGData.ProjectDetails)
        Me.projectDetailXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("Project", DevExpress.Xpo.SortDirection.None, "[Project]", False, True), New DevExpress.Xpo.ViewProperty("ProjectDtail", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True), New DevExpress.Xpo.ViewProperty("CustomerPO", DevExpress.Xpo.SortDirection.None, "[CustomerPO]", False, True), New DevExpress.Xpo.ViewProperty("BagsNeeded", DevExpress.Xpo.SortDirection.None, "[BagsRequested] - [ProjectProduction][].Sum([BagsProduced])", False, True), New DevExpress.Xpo.ViewProperty("Item Code", DevExpress.Xpo.SortDirection.None, "[ProjectItem.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ProjectItemID", DevExpress.Xpo.SortDirection.None, "[ProjectItem.ItemID]", False, True)})
        '
        'projectItemsXpView
        '
        Me.projectItemsXpView.CriteriaString = "[Project.ProjectStatus] <> 3L"
        Me.projectItemsXpView.ObjectType = GetType(DXDAL.SPGData.ProjectDetails)
        Me.projectItemsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ProjectItem.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[ProjectItem.ItemDescription]", False, True), New DevExpress.Xpo.ViewProperty("DefaultMachine", DevExpress.Xpo.SortDirection.None, "[ProjectItem.ItemDefaultMachine.MachineLineName]", False, True), New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ProjectItem.ItemID]", False, True), New DevExpress.Xpo.ViewProperty("Project", DevExpress.Xpo.SortDirection.None, "[Project.Oid]", False, True), New DevExpress.Xpo.ViewProperty("ProjectDetail", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True)})
        '
        'quantityTextEdit
        '
        Me.quantityTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.quantityTextEdit.Location = New System.Drawing.Point(399, 122)
        Me.quantityTextEdit.Name = "quantityTextEdit"
        Me.quantityTextEdit.Size = New System.Drawing.Size(112, 20)
        Me.quantityTextEdit.TabIndex = 41
        '
        'schedByQuantityCheckEdit
        '
        Me.schedByQuantityCheckEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.schedByQuantityCheckEdit.Location = New System.Drawing.Point(267, 174)
        Me.schedByQuantityCheckEdit.Name = "schedByQuantityCheckEdit"
        Me.schedByQuantityCheckEdit.Properties.Caption = "Schedule by Quantity"
        Me.schedByQuantityCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.schedByQuantityCheckEdit.Size = New System.Drawing.Size(126, 19)
        Me.schedByQuantityCheckEdit.TabIndex = 42
        '
        'priorityComboBoxEdit
        '
        Me.priorityComboBoxEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.priorityComboBoxEdit.Location = New System.Drawing.Point(399, 146)
        Me.priorityComboBoxEdit.Name = "priorityComboBoxEdit"
        Me.priorityComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.priorityComboBoxEdit.Properties.Items.AddRange(New Object() {"1", "2", "3"})
        Me.priorityComboBoxEdit.Size = New System.Drawing.Size(113, 20)
        Me.priorityComboBoxEdit.TabIndex = 43
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl6.Location = New System.Drawing.Point(324, 125)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 44
        Me.LabelControl6.Text = "Quantity:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl7.Location = New System.Drawing.Point(323, 150)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl7.TabIndex = 45
        Me.LabelControl7.Text = "Priority:"
        '
        'CustomAppointmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(528, 417)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.priorityComboBoxEdit)
        Me.Controls.Add(Me.schedByQuantityCheckEdit)
        Me.Controls.Add(Me.quantityTextEdit)
        Me.Controls.Add(Me.projectDetailLookUpEdit)
        Me.Controls.Add(Me.projectLookUpEdit)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.itemDescriptionMemoEdit)
        Me.Controls.Add(Me.mustRunCheckEdit)
        Me.Controls.Add(Me.itemLookUpEdit)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.operatorTextEdit)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.peopleTextEdit)
        Me.MinimumSize = New System.Drawing.Size(518, 307)
        Me.Name = "CustomAppointmentForm"
        Me.Controls.SetChildIndex(Me.edtShowTimeAs, 0)
        Me.Controls.SetChildIndex(Me.edtEndTime, 0)
        Me.Controls.SetChildIndex(Me.edtEndDate, 0)
        Me.Controls.SetChildIndex(Me.btnRecurrence, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.lblShowTimeAs, 0)
        Me.Controls.SetChildIndex(Me.lblEndTime, 0)
        Me.Controls.SetChildIndex(Me.tbLocation, 0)
        Me.Controls.SetChildIndex(Me.lblSubject, 0)
        Me.Controls.SetChildIndex(Me.lblLocation, 0)
        Me.Controls.SetChildIndex(Me.tbSubject, 0)
        Me.Controls.SetChildIndex(Me.lblStartTime, 0)
        Me.Controls.SetChildIndex(Me.btnOk, 0)
        Me.Controls.SetChildIndex(Me.edtStartDate, 0)
        Me.Controls.SetChildIndex(Me.edtStartTime, 0)
        Me.Controls.SetChildIndex(Me.panel1, 0)
        Me.Controls.SetChildIndex(Me.progressPanel, 0)
        Me.Controls.SetChildIndex(Me.tbDescription, 0)
        Me.Controls.SetChildIndex(Me.peopleTextEdit, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.operatorTextEdit, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.itemLookUpEdit, 0)
        Me.Controls.SetChildIndex(Me.mustRunCheckEdit, 0)
        Me.Controls.SetChildIndex(Me.itemDescriptionMemoEdit, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.projectLookUpEdit, 0)
        Me.Controls.SetChildIndex(Me.projectDetailLookUpEdit, 0)
        Me.Controls.SetChildIndex(Me.quantityTextEdit, 0)
        Me.Controls.SetChildIndex(Me.schedByQuantityCheckEdit, 0)
        Me.Controls.SetChildIndex(Me.priorityComboBoxEdit, 0)
        Me.Controls.SetChildIndex(Me.LabelControl6, 0)
        Me.Controls.SetChildIndex(Me.LabelControl7, 0)
        CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.progressPanel.ResumeLayout(False)
        Me.progressPanel.PerformLayout()
        CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peopleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.operatorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemsXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mustRunCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemDescriptionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectsXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectDetailLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectDetailXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectItemsXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedByQuantityCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priorityComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents peopleTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents operatorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents itemLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents mustRunCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents itemsXpView As DevExpress.Xpo.XPView
    Friend WithEvents itemDescriptionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents projectsXpView As DevExpress.Xpo.XPView
    Friend WithEvents projectDetailXpView As DevExpress.Xpo.XPView
    Friend WithEvents projectLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents projectDetailLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents projectItemsXpView As DevExpress.Xpo.XPView
    Friend WithEvents quantityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents schedByQuantityCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents priorityComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl

End Class
