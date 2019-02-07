using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Columns;

//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace SuperiorPackGroup
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class ItemsXtraForm : DevExpress.XtraEditors.XtraForm
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraGrid.GridLevelNode GridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			DevExpress.XtraGrid.GridLevelNode GridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsXtraForm));
			this.poolDetailsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.poolBomGridControl = new DevExpress.XtraGrid.GridControl();
			this.poolBomXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.poolBomGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.poolBomDeleteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.poolBomDeleteRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.poolIdGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.poolsRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.itemPoolsXpView = new DevExpress.Xpo.XPView(this.components);
			this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPoolBomQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colScrapFactor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.itemsMenuBar = new DevExpress.XtraBars.Bar();
			this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.cancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.palletTicketBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.specificationsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.printGridBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.Bar2 = new DevExpress.XtraBars.Bar();
			this.Bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.customerFilterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.itemsXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.generalXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.LabelControl38 = new DevExpress.XtraEditors.LabelControl();
			this.minutesPerShiftTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.lotCodeFormatLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.lotCodeFormatsXpView = new DevExpress.Xpo.XPView(this.components);
			this.LabelControl37 = new DevExpress.XtraEditors.LabelControl();
			this.requiresExpirationDateCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.requiresLotCodeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.generateLotCodesCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.LabelControl36 = new DevExpress.XtraEditors.LabelControl();
			this.bagsPerCaseTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.inventoryGridControl = new DevExpress.XtraGrid.GridControl();
			this.inventoryXpView = new DevExpress.Xpo.XPView(this.components);
			this.inventoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colLocationCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLocationName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.upcTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.packersTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ProjectedPackersLabelControl = new DevExpress.XtraEditors.LabelControl();
			this.inactiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.LabelControl26 = new DevExpress.XtraEditors.LabelControl();
			this.caseGrossWeightTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.qtyOnHandTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl25 = new DevExpress.XtraEditors.LabelControl();
			this.uomLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.qtyPerUnitTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.unitsPerPalletTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.casesPerPalletTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.unitsPerCaseTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.standardProductionTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.defaultMachineLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.machineLineXpView = new DevExpress.Xpo.XPView(this.components);
			this.customerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.typeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.shippingXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.shippingGridControl = new DevExpress.XtraGrid.GridControl();
			this.shippingGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.shippingDetailIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingBOLGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingLotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingExpirationDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.productionGridControl = new DevExpress.XtraGrid.GridControl();
			this.productionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.productionDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionLotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionPOGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionExpirationDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.receivingsGridControl = new DevExpress.XtraGrid.GridControl();
			this.receivingsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.receivingDetailIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingLpnGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingLotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingBOLGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingExpirationDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.bomXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.SplitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
			this.bomGridControl = new DevExpress.XtraGrid.GridControl();
			this.BOMGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.bomIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FGItemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RMItemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RMRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.RMItemDescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RMQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.scrapFactorGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.availabilityXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.printSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.previewSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.availabilityGridControl = new DevExpress.XtraGrid.GridControl();
			this.availabilityGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.bomItemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.bomItemDescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.quantityOnHandGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.quantityYieldsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.localQuantityOnHandGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.localQuantityYieldsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.quantityRequiredGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.availabilityItemIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.scrapPercentageGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.isPoolGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.advancedXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.other5TextEdit = new DevExpress.XtraEditors.TextEdit();
			this.other4TextEdit = new DevExpress.XtraEditors.TextEdit();
			this.other3TextEdit = new DevExpress.XtraEditors.TextEdit();
			this.other2TextEdit = new DevExpress.XtraEditors.TextEdit();
			this.other1TextEdit = new DevExpress.XtraEditors.TextEdit();
			this.palletsTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.stretchWrapTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.boxesTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.filmTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.freightTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.rebateTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.priceTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl24 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl23 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl22 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl21 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl20 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl19 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl16 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.specificationXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.LabelControl35 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl34 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl33 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl32 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl31 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl30 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl29 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl28 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl27 = new DevExpress.XtraEditors.LabelControl();
			this.palletPatternButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
			this.instructionsMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.shelfLifeTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.layersPerPalletTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.cassesPerLayerTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.mavTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.requiredWeightTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.caseCodeMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.packageCodeMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.shippingReturnXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.shippingReturnGridControl = new DevExpress.XtraGrid.GridControl();
			this.shippingReturnGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.shippingReturnIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.returnShippingIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingReturnDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingReturnBOLGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingReturnLotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingReturnQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingReturnExpirationDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingReturnXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.receivingReturnGridControl = new DevExpress.XtraGrid.GridControl();
			this.receivingReturnGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.receivingReturnIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.returnReceivingIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingReturnLpnGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingReturnLotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingReturnQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingReturnDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingReturnBolGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingReturnExpirationDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.adjustmentXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.adjustmentGridControl = new DevExpress.XtraGrid.GridControl();
			this.adjustmentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.adjustmentIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.adjustmentDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.adjustmentOriginalQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.adjustmentNewQtyGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.adjustmentQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.adjustmentReasonGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.reasonRepositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
			this.transfersXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.transfersGridControl = new DevExpress.XtraGrid.GridControl();
			this.transfersXpView = new DevExpress.Xpo.XPView(this.components);
			this.transfersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFromLocation = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colToLocation = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLot = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransferQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUnits = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPallets = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionStandardsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.productionStandardsGridControl = new DevExpress.XtraGrid.GridControl();
			this.productionStandardsXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.productionStandardsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.delProdStdGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.delProdStdRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.colOid1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHasChanges = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.machineRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colProductionPerMinute = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMinutesPerShift = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProjectedPackers = new DevExpress.XtraGrid.Columns.GridColumn();
			this.typeFilterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.clearFilterSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.patternOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.itemsSearchGridControl = new DevExpress.XtraGrid.GridControl();
			this.itemSearchXPView = new DevExpress.Xpo.XPView(this.components);
			this.itemSearchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.itemIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemCustomerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.inactiveSearchCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.BehaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
			this.AllergenInfoCheckedComboBoxEdit = new DevExpress.XtraEditors.CheckedComboBoxEdit();
			this.LabelControl39 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolBomGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolBomXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolBomGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolBomDeleteRepositoryItemButtonEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolsRepositoryItemLookUpEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemPoolsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerFilterLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsXtraTabControl).BeginInit();
			this.itemsXtraTabControl.SuspendLayout();
			this.generalXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.minutesPerShiftTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.requiresExpirationDateCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.requiresLotCodeCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.generateLotCodesCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.bagsPerCaseTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.upcTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.packersTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inactiveCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.caseGrossWeightTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.qtyOnHandTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.uomLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.qtyPerUnitTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.unitsPerPalletTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.casesPerPalletTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.unitsPerCaseTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.standardProductionTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.codeTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.defaultMachineLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.machineLineXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.typeLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.descriptionMemoEdit.Properties).BeginInit();
			this.shippingXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.shippingGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingGridView).BeginInit();
			this.productionXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.productionGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionGridView).BeginInit();
			this.receivingXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.receivingsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.receivingsGridView).BeginInit();
			this.bomXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl2).BeginInit();
			this.SplitContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.bomGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.BOMGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RMRepositoryItemLookUpEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).BeginInit();
			this.availabilityXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.availabilityGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.availabilityGridView).BeginInit();
			this.advancedXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.other5TextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.other4TextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.other3TextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.other2TextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.other1TextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.palletsTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.stretchWrapTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.boxesTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.filmTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.freightTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.rebateTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.priceTextEdit.Properties).BeginInit();
			this.specificationXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.palletPatternButtonEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.instructionsMemoEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shelfLifeTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.layersPerPalletTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.cassesPerLayerTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.mavTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.requiredWeightTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.caseCodeMemoEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.packageCodeMemoEdit.Properties).BeginInit();
			this.shippingReturnXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.shippingReturnGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingReturnGridView).BeginInit();
			this.receivingReturnXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.receivingReturnGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.receivingReturnGridView).BeginInit();
			this.adjustmentXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.adjustmentGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.adjustmentGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reasonRepositoryItemMemoExEdit).BeginInit();
			this.transfersXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.transfersGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transfersXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transfersGridView).BeginInit();
			this.productionStandardsXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.productionStandardsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionStandardsXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionStandardsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.delProdStdRepositoryItemButtonEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.machineRepositoryItemLookUpEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.typeFilterLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.itemsSearchGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemSearchXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemSearchGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inactiveSearchCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.BehaviorManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.AllergenInfoCheckedComboBoxEdit.Properties).BeginInit();
			this.SuspendLayout();
			//
			//poolDetailsGridView
			//
			this.poolDetailsGridView.GridControl = this.poolBomGridControl;
			this.poolDetailsGridView.Name = "poolDetailsGridView";
			this.poolDetailsGridView.OptionsBehavior.Editable = false;
			//
			//poolBomGridControl
			//
			this.poolBomGridControl.DataSource = this.poolBomXpCollection;
			this.poolBomGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			GridLevelNode2.LevelTemplate = this.poolDetailsGridView;
			GridLevelNode2.RelationName = "Details";
			GridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {GridLevelNode2});
			GridLevelNode1.RelationName = "ItemPoolID";
			this.poolBomGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {GridLevelNode1});
			this.poolBomGridControl.Location = new System.Drawing.Point(0, 0);
			this.poolBomGridControl.MainView = this.poolBomGridView;
			this.poolBomGridControl.MenuManager = this.BarManager1;
			this.poolBomGridControl.Name = "poolBomGridControl";
			this.poolBomGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.poolsRepositoryItemLookUpEdit, this.poolBomDeleteRepositoryItemButtonEdit});
			this.poolBomGridControl.Size = new System.Drawing.Size(686, 240);
			this.poolBomGridControl.TabIndex = 2;
			this.poolBomGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.poolBomGridView, this.poolDetailsGridView});
			//
			//poolBomXpCollection
			//
			this.poolBomXpCollection.ObjectType = typeof(DXDAL.SPGData.PoolBom);
			//
			//poolBomGridView
			//
			this.poolBomGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.poolBomDeleteGridColumn, this.colOid, this.poolIdGridColumn, this.GridColumn4, this.colPoolBomQuantity, this.colScrapFactor});
			this.poolBomGridView.GridControl = this.poolBomGridControl;
			this.poolBomGridView.Name = "poolBomGridView";
			this.poolBomGridView.OptionsSelection.MultiSelect = true;
			this.poolBomGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.poolBomGridView.OptionsView.ShowDetailButtons = false;
			this.poolBomGridView.OptionsView.ShowGroupPanel = false;
			//
			//poolBomDeleteGridColumn
			//
			this.poolBomDeleteGridColumn.ColumnEdit = this.poolBomDeleteRepositoryItemButtonEdit;
			this.poolBomDeleteGridColumn.MaxWidth = 25;
			this.poolBomDeleteGridColumn.MinWidth = 25;
			this.poolBomDeleteGridColumn.Name = "poolBomDeleteGridColumn";
			this.poolBomDeleteGridColumn.OptionsColumn.AllowSize = false;
			this.poolBomDeleteGridColumn.OptionsColumn.FixedWidth = true;
			this.poolBomDeleteGridColumn.Visible = true;
			this.poolBomDeleteGridColumn.VisibleIndex = 0;
			this.poolBomDeleteGridColumn.Width = 38;
			//
			//poolBomDeleteRepositoryItemButtonEdit
			//
			this.poolBomDeleteRepositoryItemButtonEdit.AutoHeight = false;
			this.poolBomDeleteRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.poolBomDeleteRepositoryItemButtonEdit.Name = "poolBomDeleteRepositoryItemButtonEdit";
			this.poolBomDeleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			//
			//colOid
			//
			this.colOid.FieldName = "Oid";
			this.colOid.Name = "colOid";
			//
			//poolIdGridColumn
			//
			this.poolIdGridColumn.ColumnEdit = this.poolsRepositoryItemLookUpEdit;
			this.poolIdGridColumn.FieldName = "ItemPoolID!Key";
			this.poolIdGridColumn.Name = "poolIdGridColumn";
			this.poolIdGridColumn.Visible = true;
			this.poolIdGridColumn.VisibleIndex = 1;
			this.poolIdGridColumn.Width = 156;
			//
			//poolsRepositoryItemLookUpEdit
			//
			this.poolsRepositoryItemLookUpEdit.AutoHeight = false;
			this.poolsRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.poolsRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PoolID", "Pool ID", 57, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PoolCode", "Pool Code", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.poolsRepositoryItemLookUpEdit.DataSource = this.itemPoolsXpView;
			this.poolsRepositoryItemLookUpEdit.DisplayMember = "PoolCode";
			this.poolsRepositoryItemLookUpEdit.Name = "poolsRepositoryItemLookUpEdit";
			this.poolsRepositoryItemLookUpEdit.NullText = "";
			this.poolsRepositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
			this.poolsRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.poolsRepositoryItemLookUpEdit.ValueMember = "PoolID";
			//
			//itemPoolsXpView
			//
			this.itemPoolsXpView.ObjectType = typeof(DXDAL.SPGData.ItemPool);
			this.itemPoolsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("PoolID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("PoolCode", DevExpress.Xpo.SortDirection.None, "[PoolCode]", false, true)
			});
			//
			//GridColumn4
			//
			this.GridColumn4.FieldName = "PoolBomFiniGoodID!Key";
			this.GridColumn4.Name = "GridColumn4";
			//
			//colPoolBomQuantity
			//
			this.colPoolBomQuantity.FieldName = "PoolBomQuantity";
			this.colPoolBomQuantity.Name = "colPoolBomQuantity";
			this.colPoolBomQuantity.Visible = true;
			this.colPoolBomQuantity.VisibleIndex = 2;
			this.colPoolBomQuantity.Width = 156;
			//
			//colScrapFactor
			//
			this.colScrapFactor.DisplayFormat.FormatString = "{0}%";
			this.colScrapFactor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colScrapFactor.FieldName = "ScrapFactor";
			this.colScrapFactor.Name = "colScrapFactor";
			this.colScrapFactor.Visible = true;
			this.colScrapFactor.VisibleIndex = 3;
			this.colScrapFactor.Width = 200;
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.itemsMenuBar, this.Bar2, this.Bar3});
			this.BarManager1.DockControls.Add(this.barDockControlTop);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.addBarButtonItem, this.editBarButtonItem, this.deleteBarButtonItem, this.cancelBarButtonItem, this.saveBarButtonItem, this.palletTicketBarButtonItem, this.printGridBarButtonItem, this.specificationsBarButtonItem});
			this.BarManager1.MainMenu = this.Bar2;
			this.BarManager1.MaxItemId = 8;
			this.BarManager1.StatusBar = this.Bar3;
			//
			//itemsMenuBar
			//
			this.itemsMenuBar.BarName = "Tools";
			this.itemsMenuBar.DockCol = 0;
			this.itemsMenuBar.DockRow = 1;
			this.itemsMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.itemsMenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.deleteBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.cancelBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.palletTicketBarButtonItem, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.specificationsBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.printGridBarButtonItem)
			});
			this.itemsMenuBar.OptionsBar.UseWholeRow = true;
			this.itemsMenuBar.Text = "Tools";
			//
			//addBarButtonItem
			//
			this.addBarButtonItem.Caption = "&Add Item";
			this.addBarButtonItem.Id = 0;
			this.addBarButtonItem.Name = "addBarButtonItem";
			//
			//editBarButtonItem
			//
			this.editBarButtonItem.Caption = "&Edit Item";
			this.editBarButtonItem.Id = 1;
			this.editBarButtonItem.Name = "editBarButtonItem";
			//
			//deleteBarButtonItem
			//
			this.deleteBarButtonItem.Caption = "Delete Item";
			this.deleteBarButtonItem.Id = 2;
			this.deleteBarButtonItem.Name = "deleteBarButtonItem";
			//
			//cancelBarButtonItem
			//
			this.cancelBarButtonItem.Caption = "&Cancel Changes";
			this.cancelBarButtonItem.Id = 3;
			this.cancelBarButtonItem.Name = "cancelBarButtonItem";
			//
			//saveBarButtonItem
			//
			this.saveBarButtonItem.Caption = "&Save Changes";
			this.saveBarButtonItem.Id = 4;
			this.saveBarButtonItem.Name = "saveBarButtonItem";
			//
			//palletTicketBarButtonItem
			//
			this.palletTicketBarButtonItem.Caption = "Pallet &Ticket";
			this.palletTicketBarButtonItem.Id = 5;
			this.palletTicketBarButtonItem.Name = "palletTicketBarButtonItem";
			//
			//specificationsBarButtonItem
			//
			this.specificationsBarButtonItem.Caption = "Product &Specifications";
			this.specificationsBarButtonItem.Id = 7;
			this.specificationsBarButtonItem.Name = "specificationsBarButtonItem";
			//
			//printGridBarButtonItem
			//
			this.printGridBarButtonItem.Caption = "&Print Grid";
			this.printGridBarButtonItem.Id = 6;
			this.printGridBarButtonItem.Name = "printGridBarButtonItem";
			//
			//Bar2
			//
			this.Bar2.BarName = "Main menu";
			this.Bar2.DockCol = 0;
			this.Bar2.DockRow = 0;
			this.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.Bar2.OptionsBar.MultiLine = true;
			this.Bar2.OptionsBar.UseWholeRow = true;
			this.Bar2.Text = "Main menu";
			this.Bar2.Visible = false;
			//
			//Bar3
			//
			this.Bar3.BarName = "Status bar";
			this.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.Bar3.DockCol = 0;
			this.Bar3.DockRow = 0;
			this.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.Bar3.OptionsBar.AllowQuickCustomization = false;
			this.Bar3.OptionsBar.DrawDragBorder = false;
			this.Bar3.OptionsBar.UseWholeRow = true;
			this.Bar3.Text = "Status bar";
			//
			//barDockControlTop
			//
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.BarManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(947, 49);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 565);
			this.barDockControlBottom.Manager = this.BarManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(947, 23);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
			this.barDockControlLeft.Manager = this.BarManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 516);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(947, 49);
			this.barDockControlRight.Manager = this.BarManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 516);
			//
			//customerFilterLookUpEdit
			//
			this.customerFilterLookUpEdit.Location = new System.Drawing.Point(39, 3);
			this.customerFilterLookUpEdit.Name = "customerFilterLookUpEdit";
			this.customerFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.customerFilterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.customerFilterLookUpEdit.Properties.NullText = "[Filter by Customer]";
			this.customerFilterLookUpEdit.Size = new System.Drawing.Size(212, 20);
			this.customerFilterLookUpEdit.TabIndex = 1;
			this.customerFilterLookUpEdit.Visible = false;
			//
			//itemsXtraTabControl
			//
			this.itemsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemsXtraTabControl.Location = new System.Drawing.Point(0, 0);
			this.itemsXtraTabControl.Name = "itemsXtraTabControl";
			this.itemsXtraTabControl.SelectedTabPage = this.generalXtraTabPage;
			this.itemsXtraTabControl.Size = new System.Drawing.Size(692, 516);
			this.itemsXtraTabControl.TabIndex = 2;
			this.itemsXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {this.generalXtraTabPage, this.shippingXtraTabPage, this.productionXtraTabPage, this.receivingXtraTabPage, this.bomXtraTabPage, this.availabilityXtraTabPage, this.advancedXtraTabPage, this.specificationXtraTabPage, this.shippingReturnXtraTabPage, this.receivingReturnXtraTabPage, this.adjustmentXtraTabPage, this.transfersXtraTabPage, this.productionStandardsXtraTabPage});
			//
			//generalXtraTabPage
			//
			this.generalXtraTabPage.Controls.Add(this.LabelControl38);
			this.generalXtraTabPage.Controls.Add(this.minutesPerShiftTextEdit);
			this.generalXtraTabPage.Controls.Add(this.lotCodeFormatLookUpEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl37);
			this.generalXtraTabPage.Controls.Add(this.requiresExpirationDateCheckEdit);
			this.generalXtraTabPage.Controls.Add(this.requiresLotCodeCheckEdit);
			this.generalXtraTabPage.Controls.Add(this.generateLotCodesCheckEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl36);
			this.generalXtraTabPage.Controls.Add(this.bagsPerCaseTextEdit);
			this.generalXtraTabPage.Controls.Add(this.inventoryGridControl);
			this.generalXtraTabPage.Controls.Add(this.LabelControl1);
			this.generalXtraTabPage.Controls.Add(this.upcTextEdit);
			this.generalXtraTabPage.Controls.Add(this.packersTextEdit);
			this.generalXtraTabPage.Controls.Add(this.ProjectedPackersLabelControl);
			this.generalXtraTabPage.Controls.Add(this.inactiveCheckEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl26);
			this.generalXtraTabPage.Controls.Add(this.caseGrossWeightTextEdit);
			this.generalXtraTabPage.Controls.Add(this.qtyOnHandTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl25);
			this.generalXtraTabPage.Controls.Add(this.uomLookUpEdit);
			this.generalXtraTabPage.Controls.Add(this.qtyPerUnitTextEdit);
			this.generalXtraTabPage.Controls.Add(this.unitsPerPalletTextEdit);
			this.generalXtraTabPage.Controls.Add(this.casesPerPalletTextEdit);
			this.generalXtraTabPage.Controls.Add(this.unitsPerCaseTextEdit);
			this.generalXtraTabPage.Controls.Add(this.standardProductionTextEdit);
			this.generalXtraTabPage.Controls.Add(this.codeTextEdit);
			this.generalXtraTabPage.Controls.Add(this.defaultMachineLookUpEdit);
			this.generalXtraTabPage.Controls.Add(this.customerLookUpEdit);
			this.generalXtraTabPage.Controls.Add(this.typeLookUpEdit);
			this.generalXtraTabPage.Controls.Add(this.descriptionMemoEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl12);
			this.generalXtraTabPage.Controls.Add(this.LabelControl11);
			this.generalXtraTabPage.Controls.Add(this.LabelControl10);
			this.generalXtraTabPage.Controls.Add(this.LabelControl9);
			this.generalXtraTabPage.Controls.Add(this.LabelControl8);
			this.generalXtraTabPage.Controls.Add(this.LabelControl7);
			this.generalXtraTabPage.Controls.Add(this.LabelControl6);
			this.generalXtraTabPage.Controls.Add(this.LabelControl5);
			this.generalXtraTabPage.Controls.Add(this.LabelControl4);
			this.generalXtraTabPage.Controls.Add(this.LabelControl3);
			this.generalXtraTabPage.Controls.Add(this.LabelControl2);
			this.generalXtraTabPage.Name = "generalXtraTabPage";
			this.generalXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.generalXtraTabPage.Text = "General Info";
			//
			//LabelControl38
			//
			this.LabelControl38.Location = new System.Drawing.Point(265, 189);
			this.LabelControl38.Name = "LabelControl38";
			this.LabelControl38.Size = new System.Drawing.Size(85, 13);
			this.LabelControl38.TabIndex = 38;
			this.LabelControl38.Text = "Minutes per Shift:";
			//
			//minutesPerShiftTextEdit
			//
			this.minutesPerShiftTextEdit.Location = new System.Drawing.Point(398, 186);
			this.minutesPerShiftTextEdit.MenuManager = this.BarManager1;
			this.minutesPerShiftTextEdit.Name = "minutesPerShiftTextEdit";
			this.minutesPerShiftTextEdit.Size = new System.Drawing.Size(119, 20);
			this.minutesPerShiftTextEdit.TabIndex = 15;
			//
			//lotCodeFormatLookUpEdit
			//
			this.lotCodeFormatLookUpEdit.Location = new System.Drawing.Point(117, 317);
			this.lotCodeFormatLookUpEdit.MenuManager = this.BarManager1;
			this.lotCodeFormatLookUpEdit.Name = "lotCodeFormatLookUpEdit";
			this.lotCodeFormatLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lotCodeFormatLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormatID", "Format ID", 71, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormatName", "Format Name", 74, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.lotCodeFormatLookUpEdit.Properties.DataSource = this.lotCodeFormatsXpView;
			this.lotCodeFormatLookUpEdit.Properties.DisplayMember = "FormatName";
			this.lotCodeFormatLookUpEdit.Properties.NullText = "[Select Lot Code Format]";
			this.lotCodeFormatLookUpEdit.Properties.ValueMember = "FormatID";
			this.lotCodeFormatLookUpEdit.Size = new System.Drawing.Size(142, 20);
			this.lotCodeFormatLookUpEdit.TabIndex = 33;
			//
			//lotCodeFormatsXpView
			//
			this.lotCodeFormatsXpView.ObjectType = typeof(DXDAL.SPGData.LotCodeFormats);
			this.lotCodeFormatsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("FormatID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("FormatName", DevExpress.Xpo.SortDirection.Ascending, "[FormatName]", false, true)
			});
			//
			//LabelControl37
			//
			this.LabelControl37.Location = new System.Drawing.Point(16, 320);
			this.LabelControl37.Name = "LabelControl37";
			this.LabelControl37.Size = new System.Drawing.Size(84, 13);
			this.LabelControl37.TabIndex = 37;
			this.LabelControl37.Text = "Lot Code Format:";
			//
			//requiresExpirationDateCheckEdit
			//
			this.requiresExpirationDateCheckEdit.Location = new System.Drawing.Point(523, 238);
			this.requiresExpirationDateCheckEdit.MenuManager = this.BarManager1;
			this.requiresExpirationDateCheckEdit.Name = "requiresExpirationDateCheckEdit";
			this.requiresExpirationDateCheckEdit.Properties.Caption = "Requires Expiration Date";
			this.requiresExpirationDateCheckEdit.Size = new System.Drawing.Size(152, 19);
			this.requiresExpirationDateCheckEdit.TabIndex = 36;
			//
			//requiresLotCodeCheckEdit
			//
			this.requiresLotCodeCheckEdit.Location = new System.Drawing.Point(523, 212);
			this.requiresLotCodeCheckEdit.MenuManager = this.BarManager1;
			this.requiresLotCodeCheckEdit.Name = "requiresLotCodeCheckEdit";
			this.requiresLotCodeCheckEdit.Properties.Caption = "Requires Lot Code";
			this.requiresLotCodeCheckEdit.Size = new System.Drawing.Size(152, 19);
			this.requiresLotCodeCheckEdit.TabIndex = 35;
			//
			//generateLotCodesCheckEdit
			//
			this.generateLotCodesCheckEdit.Location = new System.Drawing.Point(523, 186);
			this.generateLotCodesCheckEdit.MenuManager = this.BarManager1;
			this.generateLotCodesCheckEdit.Name = "generateLotCodesCheckEdit";
			this.generateLotCodesCheckEdit.Properties.Caption = "Generate Lot Codes";
			this.generateLotCodesCheckEdit.Size = new System.Drawing.Size(152, 19);
			this.generateLotCodesCheckEdit.TabIndex = 34;
			//
			//LabelControl36
			//
			this.LabelControl36.Location = new System.Drawing.Point(265, 267);
			this.LabelControl36.Name = "LabelControl36";
			this.LabelControl36.Size = new System.Drawing.Size(73, 13);
			this.LabelControl36.TabIndex = 33;
			this.LabelControl36.Text = "Bags per Case:";
			//
			//bagsPerCaseTextEdit
			//
			this.bagsPerCaseTextEdit.Location = new System.Drawing.Point(398, 264);
			this.bagsPerCaseTextEdit.MenuManager = this.BarManager1;
			this.bagsPerCaseTextEdit.Name = "bagsPerCaseTextEdit";
			this.bagsPerCaseTextEdit.Size = new System.Drawing.Size(119, 20);
			this.bagsPerCaseTextEdit.TabIndex = 27;
			//
			//inventoryGridControl
			//
			this.inventoryGridControl.DataSource = this.inventoryXpView;
			this.inventoryGridControl.Location = new System.Drawing.Point(16, 343);
			this.inventoryGridControl.MainView = this.inventoryGridView;
			this.inventoryGridControl.MenuManager = this.BarManager1;
			this.inventoryGridControl.Name = "inventoryGridControl";
			this.inventoryGridControl.Size = new System.Drawing.Size(501, 142);
			this.inventoryGridControl.TabIndex = 31;
			this.inventoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.inventoryGridView});
			//
			//inventoryXpView
			//
			this.inventoryXpView.ObjectType = typeof(DXDAL.SPGData.LocationInventory);
			this.inventoryXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[Location.LocationCode]", false, true),
				new DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[Location.LocationName]", false, true),
				new DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[QuantityOnHand]", false, true)
			});
			//
			//inventoryGridView
			//
			this.inventoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colLocationCode, this.colLocationName, this.colQuantity});
			this.inventoryGridView.GridControl = this.inventoryGridControl;
			this.inventoryGridView.Name = "inventoryGridView";
			this.inventoryGridView.OptionsView.ShowFooter = true;
			this.inventoryGridView.OptionsView.ShowGroupPanel = false;
			//
			//colLocationCode
			//
			this.colLocationCode.FieldName = "LocationCode";
			this.colLocationCode.Name = "colLocationCode";
			this.colLocationCode.OptionsColumn.ReadOnly = true;
			this.colLocationCode.Visible = true;
			this.colLocationCode.VisibleIndex = 0;
			//
			//colLocationName
			//
			this.colLocationName.FieldName = "LocationName";
			this.colLocationName.Name = "colLocationName";
			this.colLocationName.OptionsColumn.ReadOnly = true;
			this.colLocationName.Visible = true;
			this.colLocationName.VisibleIndex = 1;
			//
			//colQuantity
			//
			this.colQuantity.DisplayFormat.FormatString = "{0:#,##0.######}";
			this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.OptionsColumn.ReadOnly = true;
			this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:#,##0.######}")});
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 2;
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(265, 319);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(24, 13);
			this.LabelControl1.TabIndex = 30;
			this.LabelControl1.Text = "UPC:";
			//
			//upcTextEdit
			//
			this.upcTextEdit.Location = new System.Drawing.Point(398, 316);
			this.upcTextEdit.MenuManager = this.BarManager1;
			this.upcTextEdit.Name = "upcTextEdit";
			this.upcTextEdit.Size = new System.Drawing.Size(119, 20);
			this.upcTextEdit.TabIndex = 35;
			//
			//packersTextEdit
			//
			this.packersTextEdit.Location = new System.Drawing.Point(117, 290);
			this.packersTextEdit.MenuManager = this.BarManager1;
			this.packersTextEdit.Name = "packersTextEdit";
			this.packersTextEdit.Size = new System.Drawing.Size(142, 20);
			this.packersTextEdit.TabIndex = 28;
			//
			//ProjectedPackersLabelControl
			//
			this.ProjectedPackersLabelControl.Location = new System.Drawing.Point(16, 293);
			this.ProjectedPackersLabelControl.Name = "ProjectedPackersLabelControl";
			this.ProjectedPackersLabelControl.Size = new System.Drawing.Size(90, 13);
			this.ProjectedPackersLabelControl.TabIndex = 27;
			this.ProjectedPackersLabelControl.Text = "Projected Packers:";
			//
			//inactiveCheckEdit
			//
			this.inactiveCheckEdit.Location = new System.Drawing.Point(523, 160);
			this.inactiveCheckEdit.Name = "inactiveCheckEdit";
			this.inactiveCheckEdit.Properties.Caption = "Inactive";
			this.inactiveCheckEdit.Size = new System.Drawing.Size(152, 19);
			this.inactiveCheckEdit.TabIndex = 32;
			//
			//LabelControl26
			//
			this.LabelControl26.Location = new System.Drawing.Point(16, 267);
			this.LabelControl26.Name = "LabelControl26";
			this.LabelControl26.Size = new System.Drawing.Size(95, 13);
			this.LabelControl26.TabIndex = 24;
			this.LabelControl26.Text = "Case Gross Weight:";
			//
			//caseGrossWeightTextEdit
			//
			this.caseGrossWeightTextEdit.Location = new System.Drawing.Point(117, 264);
			this.caseGrossWeightTextEdit.Name = "caseGrossWeightTextEdit";
			this.caseGrossWeightTextEdit.Size = new System.Drawing.Size(142, 20);
			this.caseGrossWeightTextEdit.TabIndex = 25;
			//
			//qtyOnHandTextEdit
			//
			this.qtyOnHandTextEdit.Location = new System.Drawing.Point(398, 212);
			this.qtyOnHandTextEdit.Name = "qtyOnHandTextEdit";
			this.qtyOnHandTextEdit.Properties.DisplayFormat.FormatString = "{0:#,##0.####}";
			this.qtyOnHandTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.qtyOnHandTextEdit.Properties.ReadOnly = true;
			this.qtyOnHandTextEdit.Size = new System.Drawing.Size(119, 20);
			this.qtyOnHandTextEdit.TabIndex = 19;
			this.qtyOnHandTextEdit.TabStop = false;
			//
			//LabelControl25
			//
			this.LabelControl25.Location = new System.Drawing.Point(265, 215);
			this.LabelControl25.Name = "LabelControl25";
			this.LabelControl25.Size = new System.Drawing.Size(91, 13);
			this.LabelControl25.TabIndex = 14;
			this.LabelControl25.Text = "Quantity On Hand:";
			//
			//uomLookUpEdit
			//
			this.uomLookUpEdit.Location = new System.Drawing.Point(117, 186);
			this.uomLookUpEdit.Name = "uomLookUpEdit";
			this.uomLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.uomLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.uomLookUpEdit.Size = new System.Drawing.Size(142, 20);
			this.uomLookUpEdit.TabIndex = 13;
			//
			//qtyPerUnitTextEdit
			//
			this.qtyPerUnitTextEdit.Location = new System.Drawing.Point(117, 212);
			this.qtyPerUnitTextEdit.Name = "qtyPerUnitTextEdit";
			this.qtyPerUnitTextEdit.Size = new System.Drawing.Size(142, 20);
			this.qtyPerUnitTextEdit.TabIndex = 17;
			//
			//unitsPerPalletTextEdit
			//
			this.unitsPerPalletTextEdit.Location = new System.Drawing.Point(117, 238);
			this.unitsPerPalletTextEdit.Name = "unitsPerPalletTextEdit";
			this.unitsPerPalletTextEdit.Properties.ReadOnly = true;
			this.unitsPerPalletTextEdit.Size = new System.Drawing.Size(142, 20);
			this.unitsPerPalletTextEdit.TabIndex = 21;
			this.unitsPerPalletTextEdit.TabStop = false;
			//
			//casesPerPalletTextEdit
			//
			this.casesPerPalletTextEdit.Location = new System.Drawing.Point(398, 290);
			this.casesPerPalletTextEdit.Name = "casesPerPalletTextEdit";
			this.casesPerPalletTextEdit.Size = new System.Drawing.Size(119, 20);
			this.casesPerPalletTextEdit.TabIndex = 31;
			//
			//unitsPerCaseTextEdit
			//
			this.unitsPerCaseTextEdit.Location = new System.Drawing.Point(398, 238);
			this.unitsPerCaseTextEdit.Name = "unitsPerCaseTextEdit";
			this.unitsPerCaseTextEdit.Size = new System.Drawing.Size(119, 20);
			this.unitsPerCaseTextEdit.TabIndex = 23;
			//
			//standardProductionTextEdit
			//
			this.standardProductionTextEdit.Location = new System.Drawing.Point(398, 160);
			this.standardProductionTextEdit.Name = "standardProductionTextEdit";
			this.standardProductionTextEdit.Size = new System.Drawing.Size(119, 20);
			this.standardProductionTextEdit.TabIndex = 11;
			//
			//codeTextEdit
			//
			this.codeTextEdit.Location = new System.Drawing.Point(335, 23);
			this.codeTextEdit.Name = "codeTextEdit";
			this.codeTextEdit.Size = new System.Drawing.Size(182, 20);
			this.codeTextEdit.TabIndex = 3;
			//
			//defaultMachineLookUpEdit
			//
			this.defaultMachineLookUpEdit.Location = new System.Drawing.Point(117, 160);
			this.defaultMachineLookUpEdit.Name = "defaultMachineLookUpEdit";
			this.defaultMachineLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.defaultMachineLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MachineLineID", "Machine Line ID", 98, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MachineLineName", "Machine Line", 101, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.defaultMachineLookUpEdit.Properties.DataSource = this.machineLineXpView;
			this.defaultMachineLookUpEdit.Properties.DisplayMember = "MachineLineName";
			this.defaultMachineLookUpEdit.Properties.NullText = "[Select a Machine Line]";
			this.defaultMachineLookUpEdit.Properties.ValueMember = "MachineLineID";
			this.defaultMachineLookUpEdit.Size = new System.Drawing.Size(142, 20);
			this.defaultMachineLookUpEdit.TabIndex = 9;
			//
			//machineLineXpView
			//
			this.machineLineXpView.ObjectType = typeof(DXDAL.SPGData.MachineLine);
			this.machineLineXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("MachineLineID", DevExpress.Xpo.SortDirection.None, "[MachineLineID]", false, true),
				new DevExpress.Xpo.ViewProperty("MachineLineName", DevExpress.Xpo.SortDirection.None, "[MachineLineName]", false, true)
			});
			this.machineLineXpView.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {new DevExpress.Xpo.SortProperty("[MachineLineName]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
			//
			//customerLookUpEdit
			//
			this.customerLookUpEdit.Location = new System.Drawing.Point(117, 49);
			this.customerLookUpEdit.Name = "customerLookUpEdit";
			this.customerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.customerLookUpEdit.Properties.NullText = "[Select a Customer]";
			this.customerLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.customerLookUpEdit.Size = new System.Drawing.Size(400, 20);
			this.customerLookUpEdit.TabIndex = 5;
			//
			//typeLookUpEdit
			//
			this.typeLookUpEdit.Location = new System.Drawing.Point(117, 23);
			this.typeLookUpEdit.Name = "typeLookUpEdit";
			this.typeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.typeLookUpEdit.Properties.NullText = "[Select a Item Type]";
			this.typeLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.typeLookUpEdit.Size = new System.Drawing.Size(142, 20);
			this.typeLookUpEdit.TabIndex = 1;
			//
			//descriptionMemoEdit
			//
			this.descriptionMemoEdit.Location = new System.Drawing.Point(117, 75);
			this.descriptionMemoEdit.Name = "descriptionMemoEdit";
			this.descriptionMemoEdit.Size = new System.Drawing.Size(400, 72);
			this.descriptionMemoEdit.TabIndex = 7;
			//
			//LabelControl12
			//
			this.LabelControl12.Location = new System.Drawing.Point(16, 215);
			this.LabelControl12.Name = "LabelControl12";
			this.LabelControl12.Size = new System.Drawing.Size(87, 13);
			this.LabelControl12.TabIndex = 16;
			this.LabelControl12.Text = "Quantity per Unit:";
			//
			//LabelControl11
			//
			this.LabelControl11.Location = new System.Drawing.Point(16, 241);
			this.LabelControl11.Name = "LabelControl11";
			this.LabelControl11.Size = new System.Drawing.Size(76, 13);
			this.LabelControl11.TabIndex = 20;
			this.LabelControl11.Text = "Units per Pallet:";
			//
			//LabelControl10
			//
			this.LabelControl10.Location = new System.Drawing.Point(265, 293);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(79, 13);
			this.LabelControl10.TabIndex = 22;
			this.LabelControl10.Text = "Cases per Palet:";
			//
			//LabelControl9
			//
			this.LabelControl9.Location = new System.Drawing.Point(265, 241);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(74, 13);
			this.LabelControl9.TabIndex = 18;
			this.LabelControl9.Text = "Units per Case:";
			//
			//LabelControl8
			//
			this.LabelControl8.Location = new System.Drawing.Point(16, 189);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(80, 13);
			this.LabelControl8.TabIndex = 12;
			this.LabelControl8.Text = "Unit of Measure:";
			//
			//LabelControl7
			//
			this.LabelControl7.Location = new System.Drawing.Point(265, 163);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(111, 13);
			this.LabelControl7.TabIndex = 10;
			this.LabelControl7.Text = "Default Shift Standard:";
			//
			//LabelControl6
			//
			this.LabelControl6.Location = new System.Drawing.Point(16, 163);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(81, 13);
			this.LabelControl6.TabIndex = 8;
			this.LabelControl6.Text = "Default Machine:";
			//
			//LabelControl5
			//
			this.LabelControl5.Location = new System.Drawing.Point(16, 52);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(50, 13);
			this.LabelControl5.TabIndex = 4;
			this.LabelControl5.Text = "Customer:";
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(16, 26);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(28, 13);
			this.LabelControl4.TabIndex = 0;
			this.LabelControl4.Text = "Type:";
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(16, 78);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(57, 13);
			this.LabelControl3.TabIndex = 6;
			this.LabelControl3.Text = "Description:";
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(279, 26);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(37, 13);
			this.LabelControl2.TabIndex = 2;
			this.LabelControl2.Text = "Item #:";
			//
			//shippingXtraTabPage
			//
			this.shippingXtraTabPage.Controls.Add(this.shippingGridControl);
			this.shippingXtraTabPage.Name = "shippingXtraTabPage";
			this.shippingXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.shippingXtraTabPage.Text = "Shippings";
			//
			//shippingGridControl
			//
			this.shippingGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shippingGridControl.Location = new System.Drawing.Point(0, 0);
			this.shippingGridControl.MainView = this.shippingGridView;
			this.shippingGridControl.Name = "shippingGridControl";
			this.shippingGridControl.Size = new System.Drawing.Size(686, 488);
			this.shippingGridControl.TabIndex = 0;
			this.shippingGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.shippingGridView});
			//
			//shippingGridView
			//
			this.shippingGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.shippingDetailIDGridColumn, this.shippingIDGridColumn, this.shippingDateGridColumn, this.shippingBOLGridColumn, this.shippingLotGridColumn, this.shippingQuantityGridColumn, this.shippingExpirationDateGridColumn});
			this.shippingGridView.GridControl = this.shippingGridControl;
			this.shippingGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShipDetDetQty", this.shippingQuantityGridColumn, "{0:#,##0.######}")});
			this.shippingGridView.Name = "shippingGridView";
			this.shippingGridView.OptionsBehavior.Editable = false;
			this.shippingGridView.OptionsView.ShowAutoFilterRow = true;
			this.shippingGridView.OptionsView.ShowFooter = true;
			//
			//shippingDetailIDGridColumn
			//
			this.shippingDetailIDGridColumn.Caption = "Detail ID";
			this.shippingDetailIDGridColumn.Name = "shippingDetailIDGridColumn";
			this.shippingDetailIDGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingDetailIDGridColumn.OptionsColumn.ReadOnly = true;
			//
			//shippingIDGridColumn
			//
			this.shippingIDGridColumn.Caption = "Shipping ID";
			this.shippingIDGridColumn.Name = "shippingIDGridColumn";
			this.shippingIDGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingIDGridColumn.OptionsColumn.ReadOnly = true;
			//
			//shippingDateGridColumn
			//
			this.shippingDateGridColumn.Caption = "Date";
			this.shippingDateGridColumn.Name = "shippingDateGridColumn";
			this.shippingDateGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingDateGridColumn.OptionsColumn.ReadOnly = true;
			this.shippingDateGridColumn.Visible = true;
			this.shippingDateGridColumn.VisibleIndex = 0;
			//
			//shippingBOLGridColumn
			//
			this.shippingBOLGridColumn.Caption = "BOL #";
			this.shippingBOLGridColumn.Name = "shippingBOLGridColumn";
			this.shippingBOLGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingBOLGridColumn.OptionsColumn.ReadOnly = true;
			this.shippingBOLGridColumn.Visible = true;
			this.shippingBOLGridColumn.VisibleIndex = 1;
			//
			//shippingLotGridColumn
			//
			this.shippingLotGridColumn.Caption = "Lot";
			this.shippingLotGridColumn.Name = "shippingLotGridColumn";
			this.shippingLotGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingLotGridColumn.OptionsColumn.ReadOnly = true;
			this.shippingLotGridColumn.Visible = true;
			this.shippingLotGridColumn.VisibleIndex = 2;
			//
			//shippingQuantityGridColumn
			//
			this.shippingQuantityGridColumn.Caption = "Quantity";
			this.shippingQuantityGridColumn.Name = "shippingQuantityGridColumn";
			this.shippingQuantityGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingQuantityGridColumn.OptionsColumn.ReadOnly = true;
			this.shippingQuantityGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "TOTAL        {0}")});
			this.shippingQuantityGridColumn.Visible = true;
			this.shippingQuantityGridColumn.VisibleIndex = 4;
			//
			//shippingExpirationDateGridColumn
			//
			this.shippingExpirationDateGridColumn.Caption = "Expiration Date";
			this.shippingExpirationDateGridColumn.DisplayFormat.FormatString = "d";
			this.shippingExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.shippingExpirationDateGridColumn.Name = "shippingExpirationDateGridColumn";
			this.shippingExpirationDateGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingExpirationDateGridColumn.OptionsColumn.ReadOnly = true;
			this.shippingExpirationDateGridColumn.Visible = true;
			this.shippingExpirationDateGridColumn.VisibleIndex = 3;
			//
			//productionXtraTabPage
			//
			this.productionXtraTabPage.Controls.Add(this.productionGridControl);
			this.productionXtraTabPage.Name = "productionXtraTabPage";
			this.productionXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.productionXtraTabPage.Text = "Production";
			//
			//productionGridControl
			//
			this.productionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productionGridControl.Location = new System.Drawing.Point(0, 0);
			this.productionGridControl.MainView = this.productionGridView;
			this.productionGridControl.Name = "productionGridControl";
			this.productionGridControl.Size = new System.Drawing.Size(686, 488);
			this.productionGridControl.TabIndex = 0;
			this.productionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.productionGridView});
			//
			//productionGridView
			//
			this.productionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.productionDateGridColumn, this.productionLotGridColumn, this.productionPOGridColumn, this.productionQuantityGridColumn, this.productionExpirationDateGridColumn});
			this.productionGridView.GridControl = this.productionGridControl;
			this.productionGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InventoryQuantity", this.productionQuantityGridColumn, "{0:#,##0.######}")});
			this.productionGridView.Name = "productionGridView";
			this.productionGridView.OptionsBehavior.Editable = false;
			this.productionGridView.OptionsView.ShowAutoFilterRow = true;
			this.productionGridView.OptionsView.ShowFooter = true;
			//
			//productionDateGridColumn
			//
			this.productionDateGridColumn.Caption = "Date";
			this.productionDateGridColumn.DisplayFormat.FormatString = "g";
			this.productionDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.productionDateGridColumn.Name = "productionDateGridColumn";
			this.productionDateGridColumn.OptionsColumn.AllowEdit = false;
			this.productionDateGridColumn.OptionsColumn.ReadOnly = true;
			this.productionDateGridColumn.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
			this.productionDateGridColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
			this.productionDateGridColumn.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Excel;
			this.productionDateGridColumn.Visible = true;
			this.productionDateGridColumn.VisibleIndex = 0;
			//
			//productionLotGridColumn
			//
			this.productionLotGridColumn.Caption = "Lot";
			this.productionLotGridColumn.Name = "productionLotGridColumn";
			this.productionLotGridColumn.OptionsColumn.AllowEdit = false;
			this.productionLotGridColumn.OptionsColumn.ReadOnly = true;
			this.productionLotGridColumn.Visible = true;
			this.productionLotGridColumn.VisibleIndex = 1;
			//
			//productionPOGridColumn
			//
			this.productionPOGridColumn.Caption = "PO";
			this.productionPOGridColumn.Name = "productionPOGridColumn";
			this.productionPOGridColumn.OptionsColumn.AllowEdit = false;
			this.productionPOGridColumn.OptionsColumn.ReadOnly = true;
			this.productionPOGridColumn.Visible = true;
			this.productionPOGridColumn.VisibleIndex = 3;
			//
			//productionQuantityGridColumn
			//
			this.productionQuantityGridColumn.Caption = "Quantity";
			this.productionQuantityGridColumn.Name = "productionQuantityGridColumn";
			this.productionQuantityGridColumn.OptionsColumn.AllowEdit = false;
			this.productionQuantityGridColumn.OptionsColumn.ReadOnly = true;
			this.productionQuantityGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "TOTAL        {0}")});
			this.productionQuantityGridColumn.Visible = true;
			this.productionQuantityGridColumn.VisibleIndex = 4;
			//
			//productionExpirationDateGridColumn
			//
			this.productionExpirationDateGridColumn.Caption = "Expiration Date";
			this.productionExpirationDateGridColumn.DisplayFormat.FormatString = "d";
			this.productionExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.productionExpirationDateGridColumn.Name = "productionExpirationDateGridColumn";
			this.productionExpirationDateGridColumn.OptionsColumn.AllowEdit = false;
			this.productionExpirationDateGridColumn.OptionsColumn.ReadOnly = true;
			this.productionExpirationDateGridColumn.Visible = true;
			this.productionExpirationDateGridColumn.VisibleIndex = 2;
			//
			//receivingXtraTabPage
			//
			this.receivingXtraTabPage.Controls.Add(this.receivingsGridControl);
			this.receivingXtraTabPage.Name = "receivingXtraTabPage";
			this.receivingXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.receivingXtraTabPage.Text = "Receivings";
			//
			//receivingsGridControl
			//
			this.receivingsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.receivingsGridControl.Location = new System.Drawing.Point(0, 0);
			this.receivingsGridControl.MainView = this.receivingsGridView;
			this.receivingsGridControl.Name = "receivingsGridControl";
			this.receivingsGridControl.Size = new System.Drawing.Size(686, 488);
			this.receivingsGridControl.TabIndex = 0;
			this.receivingsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.receivingsGridView});
			//
			//receivingsGridView
			//
			this.receivingsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.receivingDetailIDGridColumn, this.receivingIDGridColumn, this.receivingLpnGridColumn, this.receivingLotGridColumn, this.receivingQuantityGridColumn, this.receivingDateGridColumn, this.receivingBOLGridColumn, this.receivingExpirationDateGridColumn});
			this.receivingsGridView.GridControl = this.receivingsGridControl;
			this.receivingsGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "intUnits", this.receivingQuantityGridColumn, "{0:#,##0.######}")});
			this.receivingsGridView.Name = "receivingsGridView";
			this.receivingsGridView.OptionsBehavior.Editable = false;
			this.receivingsGridView.OptionsView.ShowAutoFilterRow = true;
			this.receivingsGridView.OptionsView.ShowFooter = true;
			//
			//receivingDetailIDGridColumn
			//
			this.receivingDetailIDGridColumn.Caption = "Detail ID";
			this.receivingDetailIDGridColumn.Name = "receivingDetailIDGridColumn";
			this.receivingDetailIDGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingDetailIDGridColumn.OptionsColumn.ReadOnly = true;
			//
			//receivingIDGridColumn
			//
			this.receivingIDGridColumn.Caption = "Receiving ID";
			this.receivingIDGridColumn.Name = "receivingIDGridColumn";
			this.receivingIDGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingIDGridColumn.OptionsColumn.ReadOnly = true;
			//
			//receivingLpnGridColumn
			//
			this.receivingLpnGridColumn.Caption = "LPN";
			this.receivingLpnGridColumn.Name = "receivingLpnGridColumn";
			this.receivingLpnGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingLpnGridColumn.OptionsColumn.ReadOnly = true;
			this.receivingLpnGridColumn.Visible = true;
			this.receivingLpnGridColumn.VisibleIndex = 1;
			//
			//receivingLotGridColumn
			//
			this.receivingLotGridColumn.Caption = "Lot";
			this.receivingLotGridColumn.Name = "receivingLotGridColumn";
			this.receivingLotGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingLotGridColumn.OptionsColumn.ReadOnly = true;
			this.receivingLotGridColumn.Visible = true;
			this.receivingLotGridColumn.VisibleIndex = 2;
			//
			//receivingQuantityGridColumn
			//
			this.receivingQuantityGridColumn.Caption = "Quantity";
			this.receivingQuantityGridColumn.Name = "receivingQuantityGridColumn";
			this.receivingQuantityGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingQuantityGridColumn.OptionsColumn.ReadOnly = true;
			this.receivingQuantityGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "TOTAL        {0}")});
			this.receivingQuantityGridColumn.Visible = true;
			this.receivingQuantityGridColumn.VisibleIndex = 5;
			//
			//receivingDateGridColumn
			//
			this.receivingDateGridColumn.Caption = "Date";
			this.receivingDateGridColumn.Name = "receivingDateGridColumn";
			this.receivingDateGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingDateGridColumn.OptionsColumn.ReadOnly = true;
			this.receivingDateGridColumn.Visible = true;
			this.receivingDateGridColumn.VisibleIndex = 0;
			//
			//receivingBOLGridColumn
			//
			this.receivingBOLGridColumn.Caption = "BOL";
			this.receivingBOLGridColumn.Name = "receivingBOLGridColumn";
			this.receivingBOLGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingBOLGridColumn.OptionsColumn.ReadOnly = true;
			this.receivingBOLGridColumn.Visible = true;
			this.receivingBOLGridColumn.VisibleIndex = 4;
			//
			//receivingExpirationDateGridColumn
			//
			this.receivingExpirationDateGridColumn.Caption = "Expiration Date";
			this.receivingExpirationDateGridColumn.DisplayFormat.FormatString = "d";
			this.receivingExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.receivingExpirationDateGridColumn.Name = "receivingExpirationDateGridColumn";
			this.receivingExpirationDateGridColumn.Visible = true;
			this.receivingExpirationDateGridColumn.VisibleIndex = 3;
			//
			//bomXtraTabPage
			//
			this.bomXtraTabPage.Controls.Add(this.SplitContainerControl2);
			this.bomXtraTabPage.Name = "bomXtraTabPage";
			this.bomXtraTabPage.PageVisible = false;
			this.bomXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.bomXtraTabPage.Text = "BOM";
			//
			//SplitContainerControl2
			//
			this.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl2.Horizontal = false;
			this.SplitContainerControl2.Location = new System.Drawing.Point(0, 0);
			this.SplitContainerControl2.Name = "SplitContainerControl2";
			this.SplitContainerControl2.Panel1.Controls.Add(this.bomGridControl);
			this.SplitContainerControl2.Panel1.Text = "Panel1";
			this.SplitContainerControl2.Panel2.Controls.Add(this.poolBomGridControl);
			this.SplitContainerControl2.Panel2.Text = "Panel2";
			this.SplitContainerControl2.Size = new System.Drawing.Size(686, 488);
			this.SplitContainerControl2.SplitterPosition = 243;
			this.SplitContainerControl2.TabIndex = 2;
			this.SplitContainerControl2.Text = "SplitContainerControl2";
			//
			//bomGridControl
			//
			this.bomGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bomGridControl.Location = new System.Drawing.Point(0, 0);
			this.bomGridControl.MainView = this.BOMGridView;
			this.bomGridControl.Name = "bomGridControl";
			this.bomGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.RMRepositoryItemLookUpEdit, this.deleteRepositoryItemButtonEdit});
			this.bomGridControl.Size = new System.Drawing.Size(686, 243);
			this.bomGridControl.TabIndex = 1;
			this.bomGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.BOMGridView});
			//
			//BOMGridView
			//
			this.BOMGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.bomIDGridColumn, this.FGItemCodeGridColumn, this.RMItemCodeGridColumn, this.RMItemDescriptionGridColumn, this.RMQuantityGridColumn, this.scrapFactorGridColumn, this.deleteGridColumn});
			this.BOMGridView.GridControl = this.bomGridControl;
			this.BOMGridView.Name = "BOMGridView";
			this.BOMGridView.OptionsSelection.MultiSelect = true;
			this.BOMGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			//
			//bomIDGridColumn
			//
			this.bomIDGridColumn.Caption = "BOM ID";
			this.bomIDGridColumn.Name = "bomIDGridColumn";
			//
			//FGItemCodeGridColumn
			//
			this.FGItemCodeGridColumn.Caption = "FG Item Code";
			this.FGItemCodeGridColumn.Name = "FGItemCodeGridColumn";
			//
			//RMItemCodeGridColumn
			//
			this.RMItemCodeGridColumn.Caption = "RM Item #";
			this.RMItemCodeGridColumn.ColumnEdit = this.RMRepositoryItemLookUpEdit;
			this.RMItemCodeGridColumn.Name = "RMItemCodeGridColumn";
			this.RMItemCodeGridColumn.Visible = true;
			this.RMItemCodeGridColumn.VisibleIndex = 1;
			//
			//RMRepositoryItemLookUpEdit
			//
			this.RMRepositoryItemLookUpEdit.AutoHeight = false;
			this.RMRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RMRepositoryItemLookUpEdit.ImmediatePopup = true;
			this.RMRepositoryItemLookUpEdit.Name = "RMRepositoryItemLookUpEdit";
			this.RMRepositoryItemLookUpEdit.NullText = "";
			this.RMRepositoryItemLookUpEdit.NullValuePrompt = "[Select a RM Item]";
			this.RMRepositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
			this.RMRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			//
			//RMItemDescriptionGridColumn
			//
			this.RMItemDescriptionGridColumn.Caption = "Item Description";
			this.RMItemDescriptionGridColumn.FieldName = "RMItemDescriptionGridColumn";
			this.RMItemDescriptionGridColumn.Name = "RMItemDescriptionGridColumn";
			this.RMItemDescriptionGridColumn.OptionsColumn.AllowEdit = false;
			this.RMItemDescriptionGridColumn.OptionsColumn.AllowFocus = false;
			this.RMItemDescriptionGridColumn.OptionsColumn.ReadOnly = true;
			this.RMItemDescriptionGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
			this.RMItemDescriptionGridColumn.Visible = true;
			this.RMItemDescriptionGridColumn.VisibleIndex = 2;
			//
			//RMQuantityGridColumn
			//
			this.RMQuantityGridColumn.Caption = "Quantity";
			this.RMQuantityGridColumn.Name = "RMQuantityGridColumn";
			this.RMQuantityGridColumn.Visible = true;
			this.RMQuantityGridColumn.VisibleIndex = 3;
			//
			//scrapFactorGridColumn
			//
			this.scrapFactorGridColumn.Caption = "Scrap Factor";
			this.scrapFactorGridColumn.DisplayFormat.FormatString = "{0}%";
			this.scrapFactorGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.scrapFactorGridColumn.Name = "scrapFactorGridColumn";
			this.scrapFactorGridColumn.Visible = true;
			this.scrapFactorGridColumn.VisibleIndex = 4;
			//
			//deleteGridColumn
			//
			this.deleteGridColumn.Caption = "GridColumn1";
			this.deleteGridColumn.ColumnEdit = this.deleteRepositoryItemButtonEdit;
			this.deleteGridColumn.MaxWidth = 25;
			this.deleteGridColumn.MinWidth = 25;
			this.deleteGridColumn.Name = "deleteGridColumn";
			this.deleteGridColumn.OptionsColumn.AllowSize = false;
			this.deleteGridColumn.OptionsColumn.FixedWidth = true;
			this.deleteGridColumn.Visible = true;
			this.deleteGridColumn.VisibleIndex = 0;
			this.deleteGridColumn.Width = 25;
			//
			//deleteRepositoryItemButtonEdit
			//
			this.deleteRepositoryItemButtonEdit.AutoHeight = false;
			this.deleteRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit";
			this.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			//
			//availabilityXtraTabPage
			//
			this.availabilityXtraTabPage.Controls.Add(this.printSimpleButton);
			this.availabilityXtraTabPage.Controls.Add(this.previewSimpleButton);
			this.availabilityXtraTabPage.Controls.Add(this.availabilityGridControl);
			this.availabilityXtraTabPage.Name = "availabilityXtraTabPage";
			this.availabilityXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.availabilityXtraTabPage.Text = "Availability";
			//
			//printSimpleButton
			//
			this.printSimpleButton.Location = new System.Drawing.Point(279, 3);
			this.printSimpleButton.Name = "printSimpleButton";
			this.printSimpleButton.Size = new System.Drawing.Size(88, 23);
			this.printSimpleButton.TabIndex = 2;
			this.printSimpleButton.Text = "&Print";
			this.printSimpleButton.Visible = false;
			//
			//previewSimpleButton
			//
			this.previewSimpleButton.Location = new System.Drawing.Point(189, 3);
			this.previewSimpleButton.Name = "previewSimpleButton";
			this.previewSimpleButton.Size = new System.Drawing.Size(84, 23);
			this.previewSimpleButton.TabIndex = 1;
			this.previewSimpleButton.Text = "Print P&review";
			this.previewSimpleButton.Visible = false;
			//
			//availabilityGridControl
			//
			this.availabilityGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.availabilityGridControl.Location = new System.Drawing.Point(0, 0);
			this.availabilityGridControl.MainView = this.availabilityGridView;
			this.availabilityGridControl.Name = "availabilityGridControl";
			this.availabilityGridControl.Size = new System.Drawing.Size(686, 488);
			this.availabilityGridControl.TabIndex = 0;
			this.availabilityGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.availabilityGridView});
			//
			//availabilityGridView
			//
			this.availabilityGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.bomItemCodeGridColumn, this.bomItemDescriptionGridColumn, this.quantityOnHandGridColumn, this.quantityYieldsGridColumn, this.localQuantityOnHandGridColumn, this.localQuantityYieldsGridColumn, this.quantityRequiredGridColumn, this.availabilityItemIDGridColumn, this.scrapPercentageGridColumn, this.isPoolGridColumn});
			this.availabilityGridView.GridControl = this.availabilityGridControl;
			this.availabilityGridView.Name = "availabilityGridView";
			this.availabilityGridView.OptionsCustomization.AllowRowSizing = true;
			this.availabilityGridView.OptionsPrint.AutoWidth = false;
			this.availabilityGridView.OptionsPrint.PrintFilterInfo = true;
			this.availabilityGridView.OptionsView.RowAutoHeight = true;
			this.availabilityGridView.OptionsView.ShowFooter = true;
			//
			//bomItemCodeGridColumn
			//
			this.bomItemCodeGridColumn.Caption = "Item Number";
			this.bomItemCodeGridColumn.Name = "bomItemCodeGridColumn";
			this.bomItemCodeGridColumn.OptionsColumn.AllowEdit = false;
			this.bomItemCodeGridColumn.OptionsColumn.ReadOnly = true;
			this.bomItemCodeGridColumn.Visible = true;
			this.bomItemCodeGridColumn.VisibleIndex = 0;
			this.bomItemCodeGridColumn.Width = 100;
			//
			//bomItemDescriptionGridColumn
			//
			this.bomItemDescriptionGridColumn.Caption = "Item Description";
			this.bomItemDescriptionGridColumn.Name = "bomItemDescriptionGridColumn";
			this.bomItemDescriptionGridColumn.OptionsColumn.AllowEdit = false;
			this.bomItemDescriptionGridColumn.OptionsColumn.ReadOnly = true;
			this.bomItemDescriptionGridColumn.Visible = true;
			this.bomItemDescriptionGridColumn.VisibleIndex = 1;
			this.bomItemDescriptionGridColumn.Width = 200;
			//
			//quantityOnHandGridColumn
			//
			this.quantityOnHandGridColumn.Caption = "Qty On Hand";
			this.quantityOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.####}";
			this.quantityOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.quantityOnHandGridColumn.Name = "quantityOnHandGridColumn";
			this.quantityOnHandGridColumn.OptionsColumn.AllowEdit = false;
			this.quantityOnHandGridColumn.OptionsColumn.ReadOnly = true;
			this.quantityOnHandGridColumn.Visible = true;
			this.quantityOnHandGridColumn.VisibleIndex = 2;
			//
			//quantityYieldsGridColumn
			//
			this.quantityYieldsGridColumn.Caption = "Yield Qty";
			this.quantityYieldsGridColumn.FieldName = "quantityYieldsGridColumn";
			this.quantityYieldsGridColumn.Name = "quantityYieldsGridColumn";
			this.quantityYieldsGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Min)});
			this.quantityYieldsGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
			this.quantityYieldsGridColumn.Visible = true;
			this.quantityYieldsGridColumn.VisibleIndex = 3;
			//
			//localQuantityOnHandGridColumn
			//
			this.localQuantityOnHandGridColumn.Caption = "Local Qty On Hand";
			this.localQuantityOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.####}";
			this.localQuantityOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.localQuantityOnHandGridColumn.Name = "localQuantityOnHandGridColumn";
			this.localQuantityOnHandGridColumn.OptionsColumn.AllowEdit = false;
			this.localQuantityOnHandGridColumn.OptionsColumn.ReadOnly = true;
			this.localQuantityOnHandGridColumn.Visible = true;
			this.localQuantityOnHandGridColumn.VisibleIndex = 4;
			//
			//localQuantityYieldsGridColumn
			//
			this.localQuantityYieldsGridColumn.Caption = "Local Yield Qty";
			this.localQuantityYieldsGridColumn.FieldName = "localQuantityYieldsGridColumn";
			this.localQuantityYieldsGridColumn.Name = "localQuantityYieldsGridColumn";
			this.localQuantityYieldsGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Min)});
			this.localQuantityYieldsGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
			this.localQuantityYieldsGridColumn.Visible = true;
			this.localQuantityYieldsGridColumn.VisibleIndex = 5;
			//
			//quantityRequiredGridColumn
			//
			this.quantityRequiredGridColumn.Caption = "GridColumn1";
			this.quantityRequiredGridColumn.Name = "quantityRequiredGridColumn";
			this.quantityRequiredGridColumn.OptionsColumn.AllowEdit = false;
			this.quantityRequiredGridColumn.OptionsColumn.ReadOnly = true;
			//
			//availabilityItemIDGridColumn
			//
			this.availabilityItemIDGridColumn.Caption = "GridColumn1";
			this.availabilityItemIDGridColumn.Name = "availabilityItemIDGridColumn";
			this.availabilityItemIDGridColumn.OptionsColumn.AllowEdit = false;
			this.availabilityItemIDGridColumn.OptionsColumn.ReadOnly = true;
			//
			//scrapPercentageGridColumn
			//
			this.scrapPercentageGridColumn.Caption = "GridColumn1";
			this.scrapPercentageGridColumn.Name = "scrapPercentageGridColumn";
			//
			//isPoolGridColumn
			//
			this.isPoolGridColumn.Caption = "Is Pool";
			this.isPoolGridColumn.Name = "isPoolGridColumn";
			//
			//advancedXtraTabPage
			//
			this.advancedXtraTabPage.Controls.Add(this.other5TextEdit);
			this.advancedXtraTabPage.Controls.Add(this.other4TextEdit);
			this.advancedXtraTabPage.Controls.Add(this.other3TextEdit);
			this.advancedXtraTabPage.Controls.Add(this.other2TextEdit);
			this.advancedXtraTabPage.Controls.Add(this.other1TextEdit);
			this.advancedXtraTabPage.Controls.Add(this.palletsTextEdit);
			this.advancedXtraTabPage.Controls.Add(this.stretchWrapTextEdit);
			this.advancedXtraTabPage.Controls.Add(this.boxesTextEdit);
			this.advancedXtraTabPage.Controls.Add(this.filmTextEdit);
			this.advancedXtraTabPage.Controls.Add(this.freightTextEdit);
			this.advancedXtraTabPage.Controls.Add(this.rebateTextEdit);
			this.advancedXtraTabPage.Controls.Add(this.priceTextEdit);
			this.advancedXtraTabPage.Controls.Add(this.LabelControl24);
			this.advancedXtraTabPage.Controls.Add(this.LabelControl23);
			this.advancedXtraTabPage.Controls.Add(this.LabelControl22);
			this.advancedXtraTabPage.Controls.Add(this.LabelControl21);
			this.advancedXtraTabPage.Controls.Add(this.LabelControl20);
			this.advancedXtraTabPage.Controls.Add(this.LabelControl19);
			this.advancedXtraTabPage.Controls.Add(this.LabelControl18);
			this.advancedXtraTabPage.Controls.Add(this.LabelControl17);
			this.advancedXtraTabPage.Controls.Add(this.LabelControl16);
			this.advancedXtraTabPage.Controls.Add(this.LabelControl15);
			this.advancedXtraTabPage.Controls.Add(this.LabelControl14);
			this.advancedXtraTabPage.Controls.Add(this.LabelControl13);
			this.advancedXtraTabPage.Name = "advancedXtraTabPage";
			this.advancedXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.advancedXtraTabPage.Text = "Advanced";
			//
			//other5TextEdit
			//
			this.other5TextEdit.Location = new System.Drawing.Point(398, 346);
			this.other5TextEdit.Name = "other5TextEdit";
			this.other5TextEdit.Properties.DisplayFormat.FormatString = "c";
			this.other5TextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.other5TextEdit.Size = new System.Drawing.Size(100, 20);
			this.other5TextEdit.TabIndex = 23;
			//
			//other4TextEdit
			//
			this.other4TextEdit.Location = new System.Drawing.Point(398, 309);
			this.other4TextEdit.Name = "other4TextEdit";
			this.other4TextEdit.Properties.DisplayFormat.FormatString = "c";
			this.other4TextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.other4TextEdit.Size = new System.Drawing.Size(100, 20);
			this.other4TextEdit.TabIndex = 19;
			//
			//other3TextEdit
			//
			this.other3TextEdit.Location = new System.Drawing.Point(398, 272);
			this.other3TextEdit.Name = "other3TextEdit";
			this.other3TextEdit.Properties.DisplayFormat.FormatString = "c";
			this.other3TextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.other3TextEdit.Size = new System.Drawing.Size(100, 20);
			this.other3TextEdit.TabIndex = 15;
			//
			//other2TextEdit
			//
			this.other2TextEdit.Location = new System.Drawing.Point(398, 235);
			this.other2TextEdit.Name = "other2TextEdit";
			this.other2TextEdit.Properties.DisplayFormat.FormatString = "c";
			this.other2TextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.other2TextEdit.Size = new System.Drawing.Size(100, 20);
			this.other2TextEdit.TabIndex = 11;
			//
			//other1TextEdit
			//
			this.other1TextEdit.Location = new System.Drawing.Point(398, 198);
			this.other1TextEdit.Name = "other1TextEdit";
			this.other1TextEdit.Properties.DisplayFormat.FormatString = "c";
			this.other1TextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.other1TextEdit.Size = new System.Drawing.Size(100, 20);
			this.other1TextEdit.TabIndex = 7;
			//
			//palletsTextEdit
			//
			this.palletsTextEdit.Location = new System.Drawing.Point(208, 346);
			this.palletsTextEdit.Name = "palletsTextEdit";
			this.palletsTextEdit.Properties.DisplayFormat.FormatString = "c";
			this.palletsTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.palletsTextEdit.Size = new System.Drawing.Size(100, 20);
			this.palletsTextEdit.TabIndex = 21;
			//
			//stretchWrapTextEdit
			//
			this.stretchWrapTextEdit.Location = new System.Drawing.Point(208, 309);
			this.stretchWrapTextEdit.Name = "stretchWrapTextEdit";
			this.stretchWrapTextEdit.Properties.DisplayFormat.FormatString = "c";
			this.stretchWrapTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.stretchWrapTextEdit.Size = new System.Drawing.Size(100, 20);
			this.stretchWrapTextEdit.TabIndex = 17;
			//
			//boxesTextEdit
			//
			this.boxesTextEdit.Location = new System.Drawing.Point(208, 272);
			this.boxesTextEdit.Name = "boxesTextEdit";
			this.boxesTextEdit.Properties.DisplayFormat.FormatString = "c";
			this.boxesTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.boxesTextEdit.Size = new System.Drawing.Size(100, 20);
			this.boxesTextEdit.TabIndex = 13;
			//
			//filmTextEdit
			//
			this.filmTextEdit.Location = new System.Drawing.Point(208, 235);
			this.filmTextEdit.Name = "filmTextEdit";
			this.filmTextEdit.Properties.DisplayFormat.FormatString = "c";
			this.filmTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.filmTextEdit.Size = new System.Drawing.Size(100, 20);
			this.filmTextEdit.TabIndex = 9;
			//
			//freightTextEdit
			//
			this.freightTextEdit.Location = new System.Drawing.Point(208, 198);
			this.freightTextEdit.Name = "freightTextEdit";
			this.freightTextEdit.Properties.DisplayFormat.FormatString = "c";
			this.freightTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.freightTextEdit.Size = new System.Drawing.Size(100, 20);
			this.freightTextEdit.TabIndex = 5;
			//
			//rebateTextEdit
			//
			this.rebateTextEdit.Location = new System.Drawing.Point(295, 158);
			this.rebateTextEdit.Name = "rebateTextEdit";
			this.rebateTextEdit.Properties.DisplayFormat.FormatString = "p";
			this.rebateTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.rebateTextEdit.Size = new System.Drawing.Size(100, 20);
			this.rebateTextEdit.TabIndex = 3;
			//
			//priceTextEdit
			//
			this.priceTextEdit.Location = new System.Drawing.Point(295, 122);
			this.priceTextEdit.Name = "priceTextEdit";
			this.priceTextEdit.Properties.DisplayFormat.FormatString = "c";
			this.priceTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.priceTextEdit.Size = new System.Drawing.Size(100, 20);
			this.priceTextEdit.TabIndex = 1;
			//
			//LabelControl24
			//
			this.LabelControl24.Location = new System.Drawing.Point(345, 349);
			this.LabelControl24.Name = "LabelControl24";
			this.LabelControl24.Size = new System.Drawing.Size(32, 13);
			this.LabelControl24.TabIndex = 22;
			this.LabelControl24.Text = "Other:";
			//
			//LabelControl23
			//
			this.LabelControl23.Location = new System.Drawing.Point(345, 312);
			this.LabelControl23.Name = "LabelControl23";
			this.LabelControl23.Size = new System.Drawing.Size(32, 13);
			this.LabelControl23.TabIndex = 18;
			this.LabelControl23.Text = "Other:";
			//
			//LabelControl22
			//
			this.LabelControl22.Location = new System.Drawing.Point(345, 275);
			this.LabelControl22.Name = "LabelControl22";
			this.LabelControl22.Size = new System.Drawing.Size(32, 13);
			this.LabelControl22.TabIndex = 14;
			this.LabelControl22.Text = "Other:";
			//
			//LabelControl21
			//
			this.LabelControl21.Location = new System.Drawing.Point(345, 238);
			this.LabelControl21.Name = "LabelControl21";
			this.LabelControl21.Size = new System.Drawing.Size(32, 13);
			this.LabelControl21.TabIndex = 10;
			this.LabelControl21.Text = "Other:";
			//
			//LabelControl20
			//
			this.LabelControl20.Location = new System.Drawing.Point(345, 201);
			this.LabelControl20.Name = "LabelControl20";
			this.LabelControl20.Size = new System.Drawing.Size(32, 13);
			this.LabelControl20.TabIndex = 6;
			this.LabelControl20.Text = "Other:";
			//
			//LabelControl19
			//
			this.LabelControl19.Location = new System.Drawing.Point(130, 349);
			this.LabelControl19.Name = "LabelControl19";
			this.LabelControl19.Size = new System.Drawing.Size(35, 13);
			this.LabelControl19.TabIndex = 20;
			this.LabelControl19.Text = "Pallets:";
			//
			//LabelControl18
			//
			this.LabelControl18.Location = new System.Drawing.Point(130, 312);
			this.LabelControl18.Name = "LabelControl18";
			this.LabelControl18.Size = new System.Drawing.Size(68, 13);
			this.LabelControl18.TabIndex = 16;
			this.LabelControl18.Text = "Stretch Wrap:";
			//
			//LabelControl17
			//
			this.LabelControl17.Location = new System.Drawing.Point(130, 275);
			this.LabelControl17.Name = "LabelControl17";
			this.LabelControl17.Size = new System.Drawing.Size(33, 13);
			this.LabelControl17.TabIndex = 12;
			this.LabelControl17.Text = "Boxes:";
			//
			//LabelControl16
			//
			this.LabelControl16.Location = new System.Drawing.Point(130, 238);
			this.LabelControl16.Name = "LabelControl16";
			this.LabelControl16.Size = new System.Drawing.Size(22, 13);
			this.LabelControl16.TabIndex = 8;
			this.LabelControl16.Text = "Film:";
			//
			//LabelControl15
			//
			this.LabelControl15.Location = new System.Drawing.Point(130, 201);
			this.LabelControl15.Name = "LabelControl15";
			this.LabelControl15.Size = new System.Drawing.Size(38, 13);
			this.LabelControl15.TabIndex = 4;
			this.LabelControl15.Text = "Freight:";
			//
			//LabelControl14
			//
			this.LabelControl14.Location = new System.Drawing.Point(239, 161);
			this.LabelControl14.Name = "LabelControl14";
			this.LabelControl14.Size = new System.Drawing.Size(39, 13);
			this.LabelControl14.TabIndex = 2;
			this.LabelControl14.Text = "Rebate:";
			//
			//LabelControl13
			//
			this.LabelControl13.Location = new System.Drawing.Point(239, 129);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(27, 13);
			this.LabelControl13.TabIndex = 0;
			this.LabelControl13.Text = "Price:";
			//
			//specificationXtraTabPage
			//
			this.specificationXtraTabPage.Controls.Add(this.LabelControl39);
			this.specificationXtraTabPage.Controls.Add(this.AllergenInfoCheckedComboBoxEdit);
			this.specificationXtraTabPage.Controls.Add(this.LabelControl35);
			this.specificationXtraTabPage.Controls.Add(this.LabelControl34);
			this.specificationXtraTabPage.Controls.Add(this.LabelControl33);
			this.specificationXtraTabPage.Controls.Add(this.LabelControl32);
			this.specificationXtraTabPage.Controls.Add(this.LabelControl31);
			this.specificationXtraTabPage.Controls.Add(this.LabelControl30);
			this.specificationXtraTabPage.Controls.Add(this.LabelControl29);
			this.specificationXtraTabPage.Controls.Add(this.LabelControl28);
			this.specificationXtraTabPage.Controls.Add(this.LabelControl27);
			this.specificationXtraTabPage.Controls.Add(this.palletPatternButtonEdit);
			this.specificationXtraTabPage.Controls.Add(this.instructionsMemoEdit);
			this.specificationXtraTabPage.Controls.Add(this.shelfLifeTextEdit);
			this.specificationXtraTabPage.Controls.Add(this.layersPerPalletTextEdit);
			this.specificationXtraTabPage.Controls.Add(this.cassesPerLayerTextEdit);
			this.specificationXtraTabPage.Controls.Add(this.mavTextEdit);
			this.specificationXtraTabPage.Controls.Add(this.requiredWeightTextEdit);
			this.specificationXtraTabPage.Controls.Add(this.caseCodeMemoEdit);
			this.specificationXtraTabPage.Controls.Add(this.packageCodeMemoEdit);
			this.specificationXtraTabPage.Name = "specificationXtraTabPage";
			this.specificationXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.specificationXtraTabPage.Text = "Specification";
			//
			//LabelControl35
			//
			this.LabelControl35.Location = new System.Drawing.Point(301, 417);
			this.LabelControl35.Name = "LabelControl35";
			this.LabelControl35.Size = new System.Drawing.Size(65, 13);
			this.LabelControl35.TabIndex = 16;
			this.LabelControl35.Text = "Pallet Pattern";
			//
			//LabelControl34
			//
			this.LabelControl34.Location = new System.Drawing.Point(301, 390);
			this.LabelControl34.Name = "LabelControl34";
			this.LabelControl34.Size = new System.Drawing.Size(80, 13);
			this.LabelControl34.TabIndex = 12;
			this.LabelControl34.Text = "Layers per Pallet";
			//
			//LabelControl33
			//
			this.LabelControl33.Location = new System.Drawing.Point(301, 364);
			this.LabelControl33.Name = "LabelControl33";
			this.LabelControl33.Size = new System.Drawing.Size(171, 13);
			this.LabelControl33.TabIndex = 8;
			this.LabelControl33.Text = "Maximum Allowance Variance (MAV)";
			//
			//LabelControl32
			//
			this.LabelControl32.Location = new System.Drawing.Point(51, 262);
			this.LabelControl32.Name = "LabelControl32";
			this.LabelControl32.Size = new System.Drawing.Size(93, 13);
			this.LabelControl32.TabIndex = 4;
			this.LabelControl32.Text = "Special Instructions";
			//
			//LabelControl31
			//
			this.LabelControl31.Location = new System.Drawing.Point(51, 417);
			this.LabelControl31.Name = "LabelControl31";
			this.LabelControl31.Size = new System.Drawing.Size(44, 13);
			this.LabelControl31.TabIndex = 14;
			this.LabelControl31.Text = "Shelf Life";
			//
			//LabelControl30
			//
			this.LabelControl30.Location = new System.Drawing.Point(51, 388);
			this.LabelControl30.Name = "LabelControl30";
			this.LabelControl30.Size = new System.Drawing.Size(78, 13);
			this.LabelControl30.TabIndex = 10;
			this.LabelControl30.Text = "Cases per Layer";
			//
			//LabelControl29
			//
			this.LabelControl29.Location = new System.Drawing.Point(51, 362);
			this.LabelControl29.Name = "LabelControl29";
			this.LabelControl29.Size = new System.Drawing.Size(113, 13);
			this.LabelControl29.TabIndex = 6;
			this.LabelControl29.Text = "Required Weight/Count";
			//
			//LabelControl28
			//
			this.LabelControl28.Location = new System.Drawing.Point(51, 160);
			this.LabelControl28.Name = "LabelControl28";
			this.LabelControl28.Size = new System.Drawing.Size(89, 13);
			this.LabelControl28.TabIndex = 2;
			this.LabelControl28.Text = "Case Code Format";
			//
			//LabelControl27
			//
			this.LabelControl27.Location = new System.Drawing.Point(51, 57);
			this.LabelControl27.Name = "LabelControl27";
			this.LabelControl27.Size = new System.Drawing.Size(105, 13);
			this.LabelControl27.TabIndex = 0;
			this.LabelControl27.Text = "Package Code Format";
			//
			//palletPatternButtonEdit
			//
			this.palletPatternButtonEdit.Location = new System.Drawing.Point(372, 414);
			this.palletPatternButtonEdit.Name = "palletPatternButtonEdit";
			this.palletPatternButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.palletPatternButtonEdit.Properties.NullText = "[Select the Pattern Image]";
			this.palletPatternButtonEdit.Size = new System.Drawing.Size(206, 20);
			this.palletPatternButtonEdit.TabIndex = 17;
			//
			//instructionsMemoEdit
			//
			this.instructionsMemoEdit.Location = new System.Drawing.Point(170, 259);
			this.instructionsMemoEdit.Name = "instructionsMemoEdit";
			this.instructionsMemoEdit.Size = new System.Drawing.Size(408, 96);
			this.instructionsMemoEdit.TabIndex = 5;
			//
			//shelfLifeTextEdit
			//
			this.shelfLifeTextEdit.Location = new System.Drawing.Point(170, 414);
			this.shelfLifeTextEdit.Name = "shelfLifeTextEdit";
			this.shelfLifeTextEdit.Size = new System.Drawing.Size(100, 20);
			this.shelfLifeTextEdit.TabIndex = 15;
			//
			//layersPerPalletTextEdit
			//
			this.layersPerPalletTextEdit.Location = new System.Drawing.Point(478, 387);
			this.layersPerPalletTextEdit.Name = "layersPerPalletTextEdit";
			this.layersPerPalletTextEdit.Size = new System.Drawing.Size(100, 20);
			this.layersPerPalletTextEdit.TabIndex = 13;
			//
			//cassesPerLayerTextEdit
			//
			this.cassesPerLayerTextEdit.Location = new System.Drawing.Point(170, 387);
			this.cassesPerLayerTextEdit.Name = "cassesPerLayerTextEdit";
			this.cassesPerLayerTextEdit.Size = new System.Drawing.Size(100, 20);
			this.cassesPerLayerTextEdit.TabIndex = 11;
			//
			//mavTextEdit
			//
			this.mavTextEdit.Location = new System.Drawing.Point(478, 361);
			this.mavTextEdit.Name = "mavTextEdit";
			this.mavTextEdit.Size = new System.Drawing.Size(100, 20);
			this.mavTextEdit.TabIndex = 9;
			//
			//requiredWeightTextEdit
			//
			this.requiredWeightTextEdit.Location = new System.Drawing.Point(170, 359);
			this.requiredWeightTextEdit.Name = "requiredWeightTextEdit";
			this.requiredWeightTextEdit.Size = new System.Drawing.Size(100, 20);
			this.requiredWeightTextEdit.TabIndex = 7;
			//
			//caseCodeMemoEdit
			//
			this.caseCodeMemoEdit.Location = new System.Drawing.Point(170, 157);
			this.caseCodeMemoEdit.Name = "caseCodeMemoEdit";
			this.caseCodeMemoEdit.Size = new System.Drawing.Size(408, 96);
			this.caseCodeMemoEdit.TabIndex = 3;
			//
			//packageCodeMemoEdit
			//
			this.packageCodeMemoEdit.Location = new System.Drawing.Point(170, 54);
			this.packageCodeMemoEdit.Name = "packageCodeMemoEdit";
			this.packageCodeMemoEdit.Size = new System.Drawing.Size(408, 96);
			this.packageCodeMemoEdit.TabIndex = 1;
			//
			//shippingReturnXtraTabPage
			//
			this.shippingReturnXtraTabPage.Controls.Add(this.shippingReturnGridControl);
			this.shippingReturnXtraTabPage.Name = "shippingReturnXtraTabPage";
			this.shippingReturnXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.shippingReturnXtraTabPage.Text = "Shipping Returns";
			//
			//shippingReturnGridControl
			//
			this.shippingReturnGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shippingReturnGridControl.Location = new System.Drawing.Point(0, 0);
			this.shippingReturnGridControl.MainView = this.shippingReturnGridView;
			this.shippingReturnGridControl.Name = "shippingReturnGridControl";
			this.shippingReturnGridControl.Size = new System.Drawing.Size(686, 488);
			this.shippingReturnGridControl.TabIndex = 1;
			this.shippingReturnGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.shippingReturnGridView});
			//
			//shippingReturnGridView
			//
			this.shippingReturnGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.shippingReturnIDGridColumn, this.returnShippingIDGridColumn, this.shippingReturnDateGridColumn, this.shippingReturnBOLGridColumn, this.shippingReturnLotGridColumn, this.shippingReturnQuantityGridColumn, this.shippingReturnExpirationDateGridColumn});
			this.shippingReturnGridView.GridControl = this.shippingReturnGridControl;
			this.shippingReturnGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "intUnits", this.shippingReturnQuantityGridColumn, "{0:#,##0.######}")});
			this.shippingReturnGridView.Name = "shippingReturnGridView";
			this.shippingReturnGridView.OptionsBehavior.Editable = false;
			this.shippingReturnGridView.OptionsView.ShowAutoFilterRow = true;
			this.shippingReturnGridView.OptionsView.ShowFooter = true;
			//
			//shippingReturnIDGridColumn
			//
			this.shippingReturnIDGridColumn.Caption = "Detail ID";
			this.shippingReturnIDGridColumn.Name = "shippingReturnIDGridColumn";
			this.shippingReturnIDGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingReturnIDGridColumn.OptionsColumn.ReadOnly = true;
			//
			//returnShippingIDGridColumn
			//
			this.returnShippingIDGridColumn.Caption = "Shipping ID";
			this.returnShippingIDGridColumn.Name = "returnShippingIDGridColumn";
			this.returnShippingIDGridColumn.OptionsColumn.AllowEdit = false;
			this.returnShippingIDGridColumn.OptionsColumn.ReadOnly = true;
			//
			//shippingReturnDateGridColumn
			//
			this.shippingReturnDateGridColumn.Caption = "Date";
			this.shippingReturnDateGridColumn.Name = "shippingReturnDateGridColumn";
			this.shippingReturnDateGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingReturnDateGridColumn.OptionsColumn.ReadOnly = true;
			this.shippingReturnDateGridColumn.Visible = true;
			this.shippingReturnDateGridColumn.VisibleIndex = 0;
			//
			//shippingReturnBOLGridColumn
			//
			this.shippingReturnBOLGridColumn.Caption = "BOL #";
			this.shippingReturnBOLGridColumn.Name = "shippingReturnBOLGridColumn";
			this.shippingReturnBOLGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingReturnBOLGridColumn.OptionsColumn.ReadOnly = true;
			this.shippingReturnBOLGridColumn.Visible = true;
			this.shippingReturnBOLGridColumn.VisibleIndex = 1;
			//
			//shippingReturnLotGridColumn
			//
			this.shippingReturnLotGridColumn.Caption = "Lot";
			this.shippingReturnLotGridColumn.Name = "shippingReturnLotGridColumn";
			this.shippingReturnLotGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingReturnLotGridColumn.OptionsColumn.ReadOnly = true;
			this.shippingReturnLotGridColumn.Visible = true;
			this.shippingReturnLotGridColumn.VisibleIndex = 2;
			//
			//shippingReturnQuantityGridColumn
			//
			this.shippingReturnQuantityGridColumn.Caption = "Quantity";
			this.shippingReturnQuantityGridColumn.Name = "shippingReturnQuantityGridColumn";
			this.shippingReturnQuantityGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingReturnQuantityGridColumn.OptionsColumn.ReadOnly = true;
			this.shippingReturnQuantityGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "TOTAL        {0}")});
			this.shippingReturnQuantityGridColumn.Visible = true;
			this.shippingReturnQuantityGridColumn.VisibleIndex = 4;
			//
			//shippingReturnExpirationDateGridColumn
			//
			this.shippingReturnExpirationDateGridColumn.Caption = "Expiration Date";
			this.shippingReturnExpirationDateGridColumn.DisplayFormat.FormatString = "d";
			this.shippingReturnExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.shippingReturnExpirationDateGridColumn.Name = "shippingReturnExpirationDateGridColumn";
			this.shippingReturnExpirationDateGridColumn.OptionsColumn.AllowEdit = false;
			this.shippingReturnExpirationDateGridColumn.OptionsColumn.ReadOnly = true;
			this.shippingReturnExpirationDateGridColumn.Visible = true;
			this.shippingReturnExpirationDateGridColumn.VisibleIndex = 3;
			//
			//receivingReturnXtraTabPage
			//
			this.receivingReturnXtraTabPage.Controls.Add(this.receivingReturnGridControl);
			this.receivingReturnXtraTabPage.Name = "receivingReturnXtraTabPage";
			this.receivingReturnXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.receivingReturnXtraTabPage.Text = "Receiving Returns";
			//
			//receivingReturnGridControl
			//
			this.receivingReturnGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.receivingReturnGridControl.Location = new System.Drawing.Point(0, 0);
			this.receivingReturnGridControl.MainView = this.receivingReturnGridView;
			this.receivingReturnGridControl.Name = "receivingReturnGridControl";
			this.receivingReturnGridControl.Size = new System.Drawing.Size(686, 488);
			this.receivingReturnGridControl.TabIndex = 1;
			this.receivingReturnGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.receivingReturnGridView});
			//
			//receivingReturnGridView
			//
			this.receivingReturnGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.receivingReturnIDGridColumn, this.returnReceivingIDGridColumn, this.receivingReturnLpnGridColumn, this.receivingReturnLotGridColumn, this.receivingReturnQuantityGridColumn, this.receivingReturnDateGridColumn, this.receivingReturnBolGridColumn, this.receivingReturnExpirationDateGridColumn});
			this.receivingReturnGridView.GridControl = this.receivingReturnGridControl;
			this.receivingReturnGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReturnDetQty", this.receivingReturnQuantityGridColumn, "{0:#,##0.######}")});
			this.receivingReturnGridView.Name = "receivingReturnGridView";
			this.receivingReturnGridView.OptionsBehavior.Editable = false;
			this.receivingReturnGridView.OptionsView.ShowAutoFilterRow = true;
			this.receivingReturnGridView.OptionsView.ShowFooter = true;
			//
			//receivingReturnIDGridColumn
			//
			this.receivingReturnIDGridColumn.Caption = "Detail ID";
			this.receivingReturnIDGridColumn.Name = "receivingReturnIDGridColumn";
			this.receivingReturnIDGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingReturnIDGridColumn.OptionsColumn.ReadOnly = true;
			//
			//returnReceivingIDGridColumn
			//
			this.returnReceivingIDGridColumn.Caption = "Receiving ID";
			this.returnReceivingIDGridColumn.Name = "returnReceivingIDGridColumn";
			this.returnReceivingIDGridColumn.OptionsColumn.AllowEdit = false;
			this.returnReceivingIDGridColumn.OptionsColumn.ReadOnly = true;
			//
			//receivingReturnLpnGridColumn
			//
			this.receivingReturnLpnGridColumn.Caption = "LPN";
			this.receivingReturnLpnGridColumn.Name = "receivingReturnLpnGridColumn";
			this.receivingReturnLpnGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingReturnLpnGridColumn.OptionsColumn.ReadOnly = true;
			this.receivingReturnLpnGridColumn.Visible = true;
			this.receivingReturnLpnGridColumn.VisibleIndex = 1;
			//
			//receivingReturnLotGridColumn
			//
			this.receivingReturnLotGridColumn.Caption = "Lot";
			this.receivingReturnLotGridColumn.Name = "receivingReturnLotGridColumn";
			this.receivingReturnLotGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingReturnLotGridColumn.OptionsColumn.ReadOnly = true;
			this.receivingReturnLotGridColumn.Visible = true;
			this.receivingReturnLotGridColumn.VisibleIndex = 2;
			//
			//receivingReturnQuantityGridColumn
			//
			this.receivingReturnQuantityGridColumn.Caption = "Quantity";
			this.receivingReturnQuantityGridColumn.Name = "receivingReturnQuantityGridColumn";
			this.receivingReturnQuantityGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingReturnQuantityGridColumn.OptionsColumn.ReadOnly = true;
			this.receivingReturnQuantityGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "TOTAL        {0}")});
			this.receivingReturnQuantityGridColumn.Visible = true;
			this.receivingReturnQuantityGridColumn.VisibleIndex = 5;
			//
			//receivingReturnDateGridColumn
			//
			this.receivingReturnDateGridColumn.Caption = "Date";
			this.receivingReturnDateGridColumn.Name = "receivingReturnDateGridColumn";
			this.receivingReturnDateGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingReturnDateGridColumn.OptionsColumn.ReadOnly = true;
			this.receivingReturnDateGridColumn.Visible = true;
			this.receivingReturnDateGridColumn.VisibleIndex = 0;
			//
			//receivingReturnBolGridColumn
			//
			this.receivingReturnBolGridColumn.Caption = "BOL";
			this.receivingReturnBolGridColumn.Name = "receivingReturnBolGridColumn";
			this.receivingReturnBolGridColumn.OptionsColumn.AllowEdit = false;
			this.receivingReturnBolGridColumn.OptionsColumn.ReadOnly = true;
			this.receivingReturnBolGridColumn.Visible = true;
			this.receivingReturnBolGridColumn.VisibleIndex = 4;
			//
			//receivingReturnExpirationDateGridColumn
			//
			this.receivingReturnExpirationDateGridColumn.Caption = "Expiration Date";
			this.receivingReturnExpirationDateGridColumn.DisplayFormat.FormatString = "d";
			this.receivingReturnExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.receivingReturnExpirationDateGridColumn.Name = "receivingReturnExpirationDateGridColumn";
			this.receivingReturnExpirationDateGridColumn.Visible = true;
			this.receivingReturnExpirationDateGridColumn.VisibleIndex = 3;
			//
			//adjustmentXtraTabPage
			//
			this.adjustmentXtraTabPage.Controls.Add(this.adjustmentGridControl);
			this.adjustmentXtraTabPage.Name = "adjustmentXtraTabPage";
			this.adjustmentXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.adjustmentXtraTabPage.Text = "Adjustments";
			//
			//adjustmentGridControl
			//
			this.adjustmentGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.adjustmentGridControl.Location = new System.Drawing.Point(0, 0);
			this.adjustmentGridControl.MainView = this.adjustmentGridView;
			this.adjustmentGridControl.Name = "adjustmentGridControl";
			this.adjustmentGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.reasonRepositoryItemMemoExEdit});
			this.adjustmentGridControl.Size = new System.Drawing.Size(686, 488);
			this.adjustmentGridControl.TabIndex = 5;
			this.adjustmentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.adjustmentGridView});
			//
			//adjustmentGridView
			//
			this.adjustmentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.adjustmentIDGridColumn, this.adjustmentDateGridColumn, this.adjustmentOriginalQuantityGridColumn, this.adjustmentNewQtyGridColumn, this.adjustmentQuantityGridColumn, this.adjustmentReasonGridColumn});
			this.adjustmentGridView.GridControl = this.adjustmentGridControl;
			this.adjustmentGridView.Name = "adjustmentGridView";
			this.adjustmentGridView.OptionsBehavior.ReadOnly = true;
			this.adjustmentGridView.OptionsView.ShowAutoFilterRow = true;
			this.adjustmentGridView.OptionsView.ShowFooter = true;
			//
			//adjustmentIDGridColumn
			//
			this.adjustmentIDGridColumn.Caption = "GridColumn1";
			this.adjustmentIDGridColumn.FieldName = "AdjustmentID";
			this.adjustmentIDGridColumn.Name = "adjustmentIDGridColumn";
			this.adjustmentIDGridColumn.OptionsColumn.AllowEdit = false;
			this.adjustmentIDGridColumn.OptionsColumn.ReadOnly = true;
			//
			//adjustmentDateGridColumn
			//
			this.adjustmentDateGridColumn.Caption = "Date";
			this.adjustmentDateGridColumn.DisplayFormat.FormatString = "D";
			this.adjustmentDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.adjustmentDateGridColumn.FieldName = "AdjustmentDate";
			this.adjustmentDateGridColumn.Name = "adjustmentDateGridColumn";
			this.adjustmentDateGridColumn.OptionsColumn.AllowEdit = false;
			this.adjustmentDateGridColumn.OptionsColumn.ReadOnly = true;
			this.adjustmentDateGridColumn.Visible = true;
			this.adjustmentDateGridColumn.VisibleIndex = 0;
			this.adjustmentDateGridColumn.Width = 98;
			//
			//adjustmentOriginalQuantityGridColumn
			//
			this.adjustmentOriginalQuantityGridColumn.Caption = "Orig. Qty";
			this.adjustmentOriginalQuantityGridColumn.DisplayFormat.FormatString = "{0:#,##0.######}";
			this.adjustmentOriginalQuantityGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.adjustmentOriginalQuantityGridColumn.FieldName = "OriginalQuantity";
			this.adjustmentOriginalQuantityGridColumn.Name = "adjustmentOriginalQuantityGridColumn";
			this.adjustmentOriginalQuantityGridColumn.OptionsColumn.AllowEdit = false;
			this.adjustmentOriginalQuantityGridColumn.OptionsColumn.FixedWidth = true;
			this.adjustmentOriginalQuantityGridColumn.OptionsColumn.ReadOnly = true;
			this.adjustmentOriginalQuantityGridColumn.Visible = true;
			this.adjustmentOriginalQuantityGridColumn.VisibleIndex = 1;
			this.adjustmentOriginalQuantityGridColumn.Width = 60;
			//
			//adjustmentNewQtyGridColumn
			//
			this.adjustmentNewQtyGridColumn.Caption = "New Qty";
			this.adjustmentNewQtyGridColumn.FieldName = "NewCount";
			this.adjustmentNewQtyGridColumn.Name = "adjustmentNewQtyGridColumn";
			this.adjustmentNewQtyGridColumn.OptionsColumn.AllowEdit = false;
			this.adjustmentNewQtyGridColumn.OptionsColumn.FixedWidth = true;
			this.adjustmentNewQtyGridColumn.OptionsColumn.ReadOnly = true;
			this.adjustmentNewQtyGridColumn.Visible = true;
			this.adjustmentNewQtyGridColumn.VisibleIndex = 2;
			this.adjustmentNewQtyGridColumn.Width = 60;
			//
			//adjustmentQuantityGridColumn
			//
			this.adjustmentQuantityGridColumn.Caption = "Adjustment";
			this.adjustmentQuantityGridColumn.DisplayFormat.FormatString = "##;-##";
			this.adjustmentQuantityGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.adjustmentQuantityGridColumn.FieldName = "adjustmentGridColumn";
			this.adjustmentQuantityGridColumn.Name = "adjustmentQuantityGridColumn";
			this.adjustmentQuantityGridColumn.OptionsColumn.AllowEdit = false;
			this.adjustmentQuantityGridColumn.OptionsColumn.FixedWidth = true;
			this.adjustmentQuantityGridColumn.OptionsColumn.ReadOnly = true;
			this.adjustmentQuantityGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.adjustmentQuantityGridColumn.Visible = true;
			this.adjustmentQuantityGridColumn.VisibleIndex = 3;
			this.adjustmentQuantityGridColumn.Width = 65;
			//
			//adjustmentReasonGridColumn
			//
			this.adjustmentReasonGridColumn.Caption = "Reason";
			this.adjustmentReasonGridColumn.ColumnEdit = this.reasonRepositoryItemMemoExEdit;
			this.adjustmentReasonGridColumn.FieldName = "Reason";
			this.adjustmentReasonGridColumn.Name = "adjustmentReasonGridColumn";
			this.adjustmentReasonGridColumn.OptionsColumn.ReadOnly = true;
			this.adjustmentReasonGridColumn.Visible = true;
			this.adjustmentReasonGridColumn.VisibleIndex = 4;
			this.adjustmentReasonGridColumn.Width = 110;
			//
			//reasonRepositoryItemMemoExEdit
			//
			this.reasonRepositoryItemMemoExEdit.AutoHeight = false;
			this.reasonRepositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.reasonRepositoryItemMemoExEdit.Name = "reasonRepositoryItemMemoExEdit";
			//
			//transfersXtraTabPage
			//
			this.transfersXtraTabPage.Controls.Add(this.transfersGridControl);
			this.transfersXtraTabPage.Name = "transfersXtraTabPage";
			this.transfersXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.transfersXtraTabPage.Text = "Transfers";
			//
			//transfersGridControl
			//
			this.transfersGridControl.DataSource = this.transfersXpView;
			this.transfersGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.transfersGridControl.Location = new System.Drawing.Point(0, 0);
			this.transfersGridControl.MainView = this.transfersGridView;
			this.transfersGridControl.MenuManager = this.BarManager1;
			this.transfersGridControl.Name = "transfersGridControl";
			this.transfersGridControl.Size = new System.Drawing.Size(686, 488);
			this.transfersGridControl.TabIndex = 0;
			this.transfersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.transfersGridView});
			//
			//transfersXpView
			//
			this.transfersXpView.CriteriaString = "[TransferItem.ItemID] = 0";
			this.transfersXpView.ObjectType = typeof(DXDAL.SPGData.LocationTransferDetails);
			this.transfersXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("Date", DevExpress.Xpo.SortDirection.Ascending, "[Transfer.TransferDate]", false, true),
				new DevExpress.Xpo.ViewProperty("FromLocation", DevExpress.Xpo.SortDirection.None, "[Transfer.FromLocation.LocationCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ToLocation", DevExpress.Xpo.SortDirection.None, "[Transfer.ToLocation.LocationCode]", false, true),
				new DevExpress.Xpo.ViewProperty("Lot", DevExpress.Xpo.SortDirection.None, "[TransferLot]", false, true),
				new DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[TransferQuantity]", false, true),
				new DevExpress.Xpo.ViewProperty("Units", DevExpress.Xpo.SortDirection.None, "[TransferUnits]", false, true),
				new DevExpress.Xpo.ViewProperty("Pallets", DevExpress.Xpo.SortDirection.None, "[TransferPallets]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemExpirationDate", DevExpress.Xpo.SortDirection.None, "[ItemExpirationDate]", false, true)
			});
			//
			//transfersGridView
			//
			this.transfersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colDate, this.colFromLocation, this.colToLocation, this.colLot, this.colTransferQuantity, this.colUnits, this.colPallets, this.colItemExpirationDate});
			this.transfersGridView.GridControl = this.transfersGridControl;
			this.transfersGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[]
			{
				new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", this.colTransferQuantity, "{0:#,##0.######}"),
				new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pallets", this.colPallets, "{0:#,##0.######}"),
				new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Units", this.colUnits, "{0:#,##0.######}")
			});
			this.transfersGridView.Name = "transfersGridView";
			this.transfersGridView.OptionsBehavior.Editable = false;
			this.transfersGridView.OptionsView.ShowAutoFilterRow = true;
			this.transfersGridView.OptionsView.ShowDetailButtons = false;
			this.transfersGridView.OptionsView.ShowFooter = true;
			//
			//colDate
			//
			this.colDate.FieldName = "Date";
			this.colDate.Name = "colDate";
			this.colDate.OptionsColumn.ReadOnly = true;
			this.colDate.Visible = true;
			this.colDate.VisibleIndex = 0;
			//
			//colFromLocation
			//
			this.colFromLocation.FieldName = "FromLocation";
			this.colFromLocation.Name = "colFromLocation";
			this.colFromLocation.OptionsColumn.ReadOnly = true;
			this.colFromLocation.Visible = true;
			this.colFromLocation.VisibleIndex = 1;
			//
			//colToLocation
			//
			this.colToLocation.FieldName = "ToLocation";
			this.colToLocation.Name = "colToLocation";
			this.colToLocation.OptionsColumn.ReadOnly = true;
			this.colToLocation.Visible = true;
			this.colToLocation.VisibleIndex = 2;
			//
			//colLot
			//
			this.colLot.FieldName = "Lot";
			this.colLot.Name = "colLot";
			this.colLot.OptionsColumn.ReadOnly = true;
			this.colLot.Visible = true;
			this.colLot.VisibleIndex = 3;
			//
			//colTransferQuantity
			//
			this.colTransferQuantity.FieldName = "Quantity";
			this.colTransferQuantity.Name = "colTransferQuantity";
			this.colTransferQuantity.OptionsColumn.ReadOnly = true;
			this.colTransferQuantity.Visible = true;
			this.colTransferQuantity.VisibleIndex = 4;
			//
			//colUnits
			//
			this.colUnits.FieldName = "Units";
			this.colUnits.Name = "colUnits";
			this.colUnits.OptionsColumn.ReadOnly = true;
			this.colUnits.Visible = true;
			this.colUnits.VisibleIndex = 5;
			//
			//colPallets
			//
			this.colPallets.FieldName = "Pallets";
			this.colPallets.Name = "colPallets";
			this.colPallets.OptionsColumn.ReadOnly = true;
			this.colPallets.Visible = true;
			this.colPallets.VisibleIndex = 6;
			//
			//colItemExpirationDate
			//
			this.colItemExpirationDate.Caption = "Item Expiration Date";
			this.colItemExpirationDate.FieldName = "ItemExpirationDate";
			this.colItemExpirationDate.Name = "colItemExpirationDate";
			this.colItemExpirationDate.Visible = true;
			this.colItemExpirationDate.VisibleIndex = 7;
			//
			//productionStandardsXtraTabPage
			//
			this.productionStandardsXtraTabPage.Controls.Add(this.productionStandardsGridControl);
			this.productionStandardsXtraTabPage.Name = "productionStandardsXtraTabPage";
			this.productionStandardsXtraTabPage.Size = new System.Drawing.Size(686, 488);
			this.productionStandardsXtraTabPage.Text = "Production Standards";
			//
			//productionStandardsGridControl
			//
			this.productionStandardsGridControl.DataSource = this.productionStandardsXpCollection;
			this.productionStandardsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productionStandardsGridControl.Location = new System.Drawing.Point(0, 0);
			this.productionStandardsGridControl.MainView = this.productionStandardsGridView;
			this.productionStandardsGridControl.MenuManager = this.BarManager1;
			this.productionStandardsGridControl.Name = "productionStandardsGridControl";
			this.productionStandardsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.machineRepositoryItemLookUpEdit, this.delProdStdRepositoryItemButtonEdit});
			this.productionStandardsGridControl.Size = new System.Drawing.Size(686, 488);
			this.productionStandardsGridControl.TabIndex = 0;
			this.productionStandardsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.productionStandardsGridView});
			//
			//productionStandardsXpCollection
			//
			this.productionStandardsXpCollection.ObjectType = typeof(DXDAL.SPGData.ItemMachineStandards);
			//
			//productionStandardsGridView
			//
			this.productionStandardsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.delProdStdGridColumn, this.colOid1, this.colHasChanges, this.GridColumn1, this.GridColumn2, this.GridColumn3, this.GridColumn5, this.colProductionPerMinute, this.colMinutesPerShift, this.colProjectedPackers});
			this.productionStandardsGridView.GridControl = this.productionStandardsGridControl;
			this.productionStandardsGridView.Name = "productionStandardsGridView";
			this.productionStandardsGridView.OptionsSelection.MultiSelect = true;
			this.productionStandardsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.productionStandardsGridView.OptionsView.ShowDetailButtons = false;
			//
			//delProdStdGridColumn
			//
			this.delProdStdGridColumn.ColumnEdit = this.delProdStdRepositoryItemButtonEdit;
			this.delProdStdGridColumn.MaxWidth = 25;
			this.delProdStdGridColumn.Name = "delProdStdGridColumn";
			this.delProdStdGridColumn.Visible = true;
			this.delProdStdGridColumn.VisibleIndex = 0;
			this.delProdStdGridColumn.Width = 22;
			//
			//delProdStdRepositoryItemButtonEdit
			//
			this.delProdStdRepositoryItemButtonEdit.AutoHeight = false;
			this.delProdStdRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.delProdStdRepositoryItemButtonEdit.Name = "delProdStdRepositoryItemButtonEdit";
			this.delProdStdRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			//
			//colOid1
			//
			this.colOid1.FieldName = "Oid";
			this.colOid1.Name = "colOid1";
			//
			//colHasChanges
			//
			this.colHasChanges.FieldName = "HasChanges";
			this.colHasChanges.Name = "colHasChanges";
			//
			//GridColumn1
			//
			this.GridColumn1.FieldName = "ProductionItem!";
			this.GridColumn1.Name = "GridColumn1";
			//
			//GridColumn2
			//
			this.GridColumn2.FieldName = "ProductionItem!Key";
			this.GridColumn2.Name = "GridColumn2";
			//
			//GridColumn3
			//
			this.GridColumn3.FieldName = "Machine!";
			this.GridColumn3.Name = "GridColumn3";
			//
			//GridColumn5
			//
			this.GridColumn5.ColumnEdit = this.machineRepositoryItemLookUpEdit;
			this.GridColumn5.FieldName = "Machine!Key";
			this.GridColumn5.Name = "GridColumn5";
			this.GridColumn5.Visible = true;
			this.GridColumn5.VisibleIndex = 1;
			this.GridColumn5.Width = 192;
			//
			//machineRepositoryItemLookUpEdit
			//
			this.machineRepositoryItemLookUpEdit.AutoHeight = false;
			this.machineRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.machineRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MachineLineID", "Machine Line ID", 98, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MachineLineName", "Machine Line Name", 101, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.machineRepositoryItemLookUpEdit.DataSource = this.machineLineXpView;
			this.machineRepositoryItemLookUpEdit.DisplayMember = "MachineLineName";
			this.machineRepositoryItemLookUpEdit.Name = "machineRepositoryItemLookUpEdit";
			this.machineRepositoryItemLookUpEdit.ValueMember = "MachineLineID";
			//
			//colProductionPerMinute
			//
			this.colProductionPerMinute.FieldName = "ProductionPerMinute";
			this.colProductionPerMinute.Name = "colProductionPerMinute";
			this.colProductionPerMinute.Visible = true;
			this.colProductionPerMinute.VisibleIndex = 2;
			this.colProductionPerMinute.Width = 192;
			//
			//colMinutesPerShift
			//
			this.colMinutesPerShift.FieldName = "MinutesPerShift";
			this.colMinutesPerShift.Name = "colMinutesPerShift";
			this.colMinutesPerShift.Visible = true;
			this.colMinutesPerShift.VisibleIndex = 3;
			this.colMinutesPerShift.Width = 193;
			//
			//colProjectedPackers
			//
			this.colProjectedPackers.FieldName = "ProjectedPackers";
			this.colProjectedPackers.Name = "colProjectedPackers";
			this.colProjectedPackers.Visible = true;
			this.colProjectedPackers.VisibleIndex = 4;
			this.colProjectedPackers.Width = 180;
			//
			//typeFilterLookUpEdit
			//
			this.typeFilterLookUpEdit.Location = new System.Drawing.Point(267, 3);
			this.typeFilterLookUpEdit.Name = "typeFilterLookUpEdit";
			this.typeFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.typeFilterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.typeFilterLookUpEdit.Properties.NullText = "[Filter By Item Type]";
			this.typeFilterLookUpEdit.Size = new System.Drawing.Size(162, 20);
			this.typeFilterLookUpEdit.TabIndex = 2;
			this.typeFilterLookUpEdit.Visible = false;
			//
			//clearFilterSimpleButton
			//
			this.clearFilterSimpleButton.Location = new System.Drawing.Point(443, 0);
			this.clearFilterSimpleButton.Name = "clearFilterSimpleButton";
			this.clearFilterSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.clearFilterSimpleButton.TabIndex = 3;
			this.clearFilterSimpleButton.Text = "Clear Filter";
			this.clearFilterSimpleButton.Visible = false;
			//
			//patternOpenFileDialog
			//
			this.patternOpenFileDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*\"";
			//
			//SplitContainerControl1
			//
			this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl1.Location = new System.Drawing.Point(0, 49);
			this.SplitContainerControl1.Name = "SplitContainerControl1";
			this.SplitContainerControl1.Panel1.Controls.Add(this.itemsSearchGridControl);
			this.SplitContainerControl1.Panel1.Controls.Add(this.inactiveSearchCheckEdit);
			this.SplitContainerControl1.Panel1.MinSize = 250;
			this.SplitContainerControl1.Panel1.Text = "Panel1";
			this.SplitContainerControl1.Panel2.Controls.Add(this.itemsXtraTabControl);
			this.SplitContainerControl1.Panel2.Controls.Add(this.clearFilterSimpleButton);
			this.SplitContainerControl1.Panel2.Controls.Add(this.customerFilterLookUpEdit);
			this.SplitContainerControl1.Panel2.Controls.Add(this.typeFilterLookUpEdit);
			this.SplitContainerControl1.Panel2.Text = "Panel2";
			this.SplitContainerControl1.Size = new System.Drawing.Size(947, 516);
			this.SplitContainerControl1.TabIndex = 8;
			this.SplitContainerControl1.Text = "SplitContainerControl1";
			//
			//itemsSearchGridControl
			//
			this.itemsSearchGridControl.DataSource = this.itemSearchXPView;
			this.itemsSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemsSearchGridControl.Location = new System.Drawing.Point(0, 0);
			this.itemsSearchGridControl.MainView = this.itemSearchGridView;
			this.itemsSearchGridControl.Name = "itemsSearchGridControl";
			this.itemsSearchGridControl.Size = new System.Drawing.Size(250, 497);
			this.itemsSearchGridControl.TabIndex = 1;
			this.itemsSearchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.itemSearchGridView});
			//
			//itemSearchXPView
			//
			this.itemSearchXPView.ObjectType = typeof(DXDAL.SPGData.Items);
			this.itemSearchXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemType", DevExpress.Xpo.SortDirection.None, "[ItemType]", false, true),
				new DevExpress.Xpo.ViewProperty("Customer", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerName]", false, true),
				new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)
			});
			//
			//itemSearchGridView
			//
			this.itemSearchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.itemIDGridColumn, this.itemCodeGridColumn, this.itemCustomerGridColumn, this.itemTypeGridColumn});
			this.itemSearchGridView.GridControl = this.itemsSearchGridControl;
			this.itemSearchGridView.Name = "itemSearchGridView";
			this.itemSearchGridView.OptionsBehavior.Editable = false;
			this.itemSearchGridView.OptionsView.ShowAutoFilterRow = true;
			this.itemSearchGridView.OptionsView.ShowGroupPanel = false;
			//
			//itemIDGridColumn
			//
			this.itemIDGridColumn.Caption = "GridColumn1";
			this.itemIDGridColumn.FieldName = "ItemID";
			this.itemIDGridColumn.Name = "itemIDGridColumn";
			//
			//itemCodeGridColumn
			//
			this.itemCodeGridColumn.Caption = "Item #";
			this.itemCodeGridColumn.FieldName = "ItemCode";
			this.itemCodeGridColumn.Name = "itemCodeGridColumn";
			this.itemCodeGridColumn.Visible = true;
			this.itemCodeGridColumn.VisibleIndex = 0;
			//
			//itemCustomerGridColumn
			//
			this.itemCustomerGridColumn.Caption = "Customer";
			this.itemCustomerGridColumn.FieldName = "Customer";
			this.itemCustomerGridColumn.Name = "itemCustomerGridColumn";
			this.itemCustomerGridColumn.Visible = true;
			this.itemCustomerGridColumn.VisibleIndex = 1;
			//
			//itemTypeGridColumn
			//
			this.itemTypeGridColumn.Caption = "Type";
			this.itemTypeGridColumn.FieldName = "ItemType";
			this.itemTypeGridColumn.Name = "itemTypeGridColumn";
			this.itemTypeGridColumn.Visible = true;
			this.itemTypeGridColumn.VisibleIndex = 2;
			//
			//inactiveSearchCheckEdit
			//
			this.inactiveSearchCheckEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.inactiveSearchCheckEdit.Location = new System.Drawing.Point(0, 497);
			this.inactiveSearchCheckEdit.Name = "inactiveSearchCheckEdit";
			this.inactiveSearchCheckEdit.Properties.Caption = "Include Inactive";
			this.inactiveSearchCheckEdit.Size = new System.Drawing.Size(250, 19);
			this.inactiveSearchCheckEdit.TabIndex = 0;
			//
			//AllergenInfoCheckedComboBoxEdit
			//
			this.AllergenInfoCheckedComboBoxEdit.Location = new System.Drawing.Point(170, 28);
			this.AllergenInfoCheckedComboBoxEdit.MenuManager = this.BarManager1;
			this.AllergenInfoCheckedComboBoxEdit.Name = "AllergenInfoCheckedComboBoxEdit";
			this.AllergenInfoCheckedComboBoxEdit.Properties.AllowMultiSelect = true;
			this.AllergenInfoCheckedComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.AllergenInfoCheckedComboBoxEdit.Size = new System.Drawing.Size(408, 20);
			this.AllergenInfoCheckedComboBoxEdit.TabIndex = 18;
			//
			//LabelControl39
			//
			this.LabelControl39.Location = new System.Drawing.Point(51, 31);
			this.LabelControl39.Name = "LabelControl39";
			this.LabelControl39.Size = new System.Drawing.Size(62, 13);
			this.LabelControl39.TabIndex = 19;
			this.LabelControl39.Text = "Allergen Info";
			//
			//ItemsXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 588);
			this.Controls.Add(this.SplitContainerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "ItemsXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Items Manager";
			((System.ComponentModel.ISupportInitialize)this.poolDetailsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolBomGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolBomXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolBomGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolBomDeleteRepositoryItemButtonEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolsRepositoryItemLookUpEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemPoolsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerFilterLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsXtraTabControl).EndInit();
			this.itemsXtraTabControl.ResumeLayout(false);
			this.generalXtraTabPage.ResumeLayout(false);
			this.generalXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.minutesPerShiftTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.requiresExpirationDateCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.requiresLotCodeCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.generateLotCodesCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.bagsPerCaseTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.upcTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.packersTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inactiveCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.caseGrossWeightTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.qtyOnHandTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.uomLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.qtyPerUnitTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.unitsPerPalletTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.casesPerPalletTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.unitsPerCaseTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.standardProductionTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.codeTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.defaultMachineLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.machineLineXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.typeLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.descriptionMemoEdit.Properties).EndInit();
			this.shippingXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.shippingGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingGridView).EndInit();
			this.productionXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.productionGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionGridView).EndInit();
			this.receivingXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.receivingsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.receivingsGridView).EndInit();
			this.bomXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl2).EndInit();
			this.SplitContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.bomGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.BOMGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RMRepositoryItemLookUpEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).EndInit();
			this.availabilityXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.availabilityGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.availabilityGridView).EndInit();
			this.advancedXtraTabPage.ResumeLayout(false);
			this.advancedXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.other5TextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.other4TextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.other3TextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.other2TextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.other1TextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.palletsTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.stretchWrapTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.boxesTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.filmTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.freightTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.rebateTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.priceTextEdit.Properties).EndInit();
			this.specificationXtraTabPage.ResumeLayout(false);
			this.specificationXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.palletPatternButtonEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.instructionsMemoEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shelfLifeTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.layersPerPalletTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.cassesPerLayerTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.mavTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.requiredWeightTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.caseCodeMemoEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.packageCodeMemoEdit.Properties).EndInit();
			this.shippingReturnXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.shippingReturnGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingReturnGridView).EndInit();
			this.receivingReturnXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.receivingReturnGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.receivingReturnGridView).EndInit();
			this.adjustmentXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.adjustmentGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.adjustmentGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reasonRepositoryItemMemoExEdit).EndInit();
			this.transfersXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.transfersGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transfersXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transfersGridView).EndInit();
			this.productionStandardsXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.productionStandardsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionStandardsXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionStandardsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.delProdStdRepositoryItemButtonEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.machineRepositoryItemLookUpEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.typeFilterLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.itemsSearchGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemSearchXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemSearchGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inactiveSearchCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.BehaviorManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.AllergenInfoCheckedComboBoxEdit.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(ItemsXtraForm_FormClosing);
			base.Load += new System.EventHandler(ItemsXtraForm_Load);
			BOMGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(BOMGridView_InitNewRow);
			BOMGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(BOMGridView_CustomUnboundColumnData);
			priceTextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(AdvancedTextEditParseEditValue);
			stretchWrapTextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(AdvancedTextEditParseEditValue);
			palletsTextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(AdvancedTextEditParseEditValue);
			other5TextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(AdvancedTextEditParseEditValue);
			other4TextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(AdvancedTextEditParseEditValue);
			other3TextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(AdvancedTextEditParseEditValue);
			other2TextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(AdvancedTextEditParseEditValue);
			other1TextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(AdvancedTextEditParseEditValue);
			freightTextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(AdvancedTextEditParseEditValue);
			filmTextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(AdvancedTextEditParseEditValue);
			boxesTextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(AdvancedTextEditParseEditValue);
			rebateTextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(rebateTextEdit_ParseEditValue);
			customerFilterLookUpEdit.EditValueChanged += new System.EventHandler(customerFilterLookUpEdit_EditValueChanged);
			typeLookUpEdit.Leave += new System.EventHandler(typeLookUpEdit_Leave);
			printSimpleButton.Click += new System.EventHandler(printSimpleButton_Click);
			availabilityGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(availabilityGridView_CustomUnboundColumnData);
			itemsXtraTabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(itemsXtraTabControl_SelectedPageChanged);
			previewSimpleButton.Click += new System.EventHandler(previewSimpleButton_Click);
			typeFilterLookUpEdit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(typeFilterLookUpEdit_Closed);
			typeFilterLookUpEdit.EditValueChanged += new System.EventHandler(typeFilterLookUpEdit_EditValueChanged);
			unitsPerCaseTextEdit.Validated += new System.EventHandler(UnitsPerPalletCalculation);
			casesPerPalletTextEdit.Validated += new System.EventHandler(UnitsPerPalletCalculation);
			clearFilterSimpleButton.Click += new System.EventHandler(clearFilterSimpleButton_Click);
			uomLookUpEdit.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(uomLookUpEdit_ProcessNewValue);
			palletPatternButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(palletPatternButtonEdit_ButtonClick);
			printGridBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(printGridBarButtonItem_ItemClick);
			itemSearchGridView.Click += new System.EventHandler(itemSearchGridView_Click);
			addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(addBarButtonItem_ItemClick);
			editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(editBarButtonItem_ItemClick);
			deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(deleteBarButtonItem_ItemClick);
			cancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(cancelBarButtonItem_ItemClick);
			saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(saveBarButtonItem_ItemClick);
			specificationsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(specificationsBarButtonItem_ItemClick);
			palletTicketBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(palletTicketBarButtonItem_ItemClick);
			inactiveSearchCheckEdit.CheckedChanged += new System.EventHandler(inactiveSearchCheckEdit_CheckedChanged);
			RMRepositoryItemLookUpEdit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(RMRepositoryItemLookUpEdit_Closed);
			deleteRepositoryItemButtonEdit.Click += new System.EventHandler(deleteRepositoryItemButtonEdit_Click);
			adjustmentGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(adjustmentGridView_RowCellStyle);
			poolBomDeleteRepositoryItemButtonEdit.Click += new System.EventHandler(poolBomDeleteRepositoryItemButtonEdit_Click);
			delProdStdRepositoryItemButtonEdit.Click += new System.EventHandler(delProdStdRepositoryItemButtonEdit_Click);
			productionGridView.FilterEditorCreated += new DevExpress.XtraGrid.Views.Base.FilterControlEventHandler(productionGridView_FilterEditorCreated);
			productionGridControl.Click += new System.EventHandler(productionGridControl_Click);
		}
		internal DevExpress.XtraEditors.LookUpEdit customerFilterLookUpEdit;
		internal DevExpress.XtraTab.XtraTabControl itemsXtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage generalXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage shippingXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage productionXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage receivingXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage bomXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage advancedXtraTabPage;
		internal DevExpress.XtraEditors.TextEdit qtyPerUnitTextEdit;
		internal DevExpress.XtraEditors.TextEdit unitsPerPalletTextEdit;
		internal DevExpress.XtraEditors.TextEdit casesPerPalletTextEdit;
		internal DevExpress.XtraEditors.TextEdit unitsPerCaseTextEdit;
		internal DevExpress.XtraEditors.TextEdit standardProductionTextEdit;
		internal DevExpress.XtraEditors.TextEdit codeTextEdit;
		internal DevExpress.XtraEditors.LookUpEdit defaultMachineLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit customerLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit typeLookUpEdit;
		internal DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl12;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraGrid.GridControl shippingGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView shippingGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingDetailIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingLotGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingQuantityGridColumn;
		internal DevExpress.XtraGrid.GridControl productionGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView productionGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn productionDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionQuantityGridColumn;
		internal DevExpress.XtraGrid.GridControl receivingsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView receivingsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingDetailIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingLotGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingQuantityGridColumn;
		internal DevExpress.XtraEditors.TextEdit other5TextEdit;
		internal DevExpress.XtraEditors.TextEdit other4TextEdit;
		internal DevExpress.XtraEditors.TextEdit other3TextEdit;
		internal DevExpress.XtraEditors.TextEdit other2TextEdit;
		internal DevExpress.XtraEditors.TextEdit other1TextEdit;
		internal DevExpress.XtraEditors.TextEdit palletsTextEdit;
		internal DevExpress.XtraEditors.TextEdit stretchWrapTextEdit;
		internal DevExpress.XtraEditors.TextEdit boxesTextEdit;
		internal DevExpress.XtraEditors.TextEdit filmTextEdit;
		internal DevExpress.XtraEditors.TextEdit freightTextEdit;
		internal DevExpress.XtraEditors.TextEdit rebateTextEdit;
		internal DevExpress.XtraEditors.TextEdit priceTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl24;
		internal DevExpress.XtraEditors.LabelControl LabelControl23;
		internal DevExpress.XtraEditors.LabelControl LabelControl22;
		internal DevExpress.XtraEditors.LabelControl LabelControl21;
		internal DevExpress.XtraEditors.LabelControl LabelControl20;
		internal DevExpress.XtraEditors.LabelControl LabelControl19;
		internal DevExpress.XtraEditors.LabelControl LabelControl18;
		internal DevExpress.XtraEditors.LabelControl LabelControl17;
		internal DevExpress.XtraEditors.LabelControl LabelControl16;
		internal DevExpress.XtraEditors.LabelControl LabelControl15;
		internal DevExpress.XtraEditors.LabelControl LabelControl14;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraEditors.LookUpEdit uomLookUpEdit;
		internal DevExpress.XtraEditors.TextEdit qtyOnHandTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl25;
		internal DevExpress.XtraTab.XtraTabPage availabilityXtraTabPage;
		internal DevExpress.XtraGrid.GridControl availabilityGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView availabilityGridView;
		internal DevExpress.XtraEditors.SimpleButton printSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton previewSimpleButton;
		internal DevExpress.XtraGrid.Columns.GridColumn bomItemCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn bomItemDescriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn quantityOnHandGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn quantityYieldsGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn quantityRequiredGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn availabilityItemIDGridColumn;
		internal DevExpress.XtraEditors.LookUpEdit typeFilterLookUpEdit;
		internal DevExpress.XtraEditors.SimpleButton clearFilterSimpleButton;
		internal DevExpress.XtraEditors.LabelControl LabelControl26;
		internal DevExpress.XtraEditors.TextEdit caseGrossWeightTextEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingBOLGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionLotGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionPOGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingBOLGridColumn;
		internal DevExpress.XtraTab.XtraTabPage specificationXtraTabPage;
		internal DevExpress.XtraEditors.LabelControl LabelControl32;
		internal DevExpress.XtraEditors.LabelControl LabelControl31;
		internal DevExpress.XtraEditors.LabelControl LabelControl30;
		internal DevExpress.XtraEditors.LabelControl LabelControl29;
		internal DevExpress.XtraEditors.LabelControl LabelControl28;
		internal DevExpress.XtraEditors.LabelControl LabelControl27;
		internal DevExpress.XtraEditors.ButtonEdit palletPatternButtonEdit;
		internal DevExpress.XtraEditors.MemoEdit instructionsMemoEdit;
		internal DevExpress.XtraEditors.TextEdit shelfLifeTextEdit;
		internal DevExpress.XtraEditors.TextEdit layersPerPalletTextEdit;
		internal DevExpress.XtraEditors.TextEdit cassesPerLayerTextEdit;
		internal DevExpress.XtraEditors.TextEdit mavTextEdit;
		internal DevExpress.XtraEditors.TextEdit requiredWeightTextEdit;
		internal DevExpress.XtraEditors.MemoEdit caseCodeMemoEdit;
		internal DevExpress.XtraEditors.MemoEdit packageCodeMemoEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl35;
		internal DevExpress.XtraEditors.LabelControl LabelControl34;
		internal DevExpress.XtraEditors.LabelControl LabelControl33;
		internal System.Windows.Forms.OpenFileDialog patternOpenFileDialog;
		internal DevExpress.XtraEditors.CheckEdit inactiveCheckEdit;
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar itemsMenuBar;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraBars.BarButtonItem addBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem editBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem cancelBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem palletTicketBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem printGridBarButtonItem;
		internal DevExpress.XtraGrid.GridControl itemsSearchGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView itemSearchGridView;
		internal DevExpress.XtraEditors.CheckEdit inactiveSearchCheckEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn itemIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemCustomerGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemTypeGridColumn;
		internal DevExpress.XtraBars.BarButtonItem specificationsBarButtonItem;
		internal DevExpress.XtraGrid.Columns.GridColumn scrapPercentageGridColumn;
		internal DevExpress.XtraEditors.LabelControl ProjectedPackersLabelControl;
		internal DevExpress.XtraEditors.TextEdit packersTextEdit;
		internal DevExpress.Xpo.XPView itemSearchXPView;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingExpirationDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingExpirationDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionExpirationDateGridColumn;
		internal DevExpress.XtraTab.XtraTabPage shippingReturnXtraTabPage;
		internal DevExpress.XtraGrid.GridControl shippingReturnGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView shippingReturnGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingReturnIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnShippingIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingReturnDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingReturnBOLGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingReturnLotGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingReturnQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingReturnExpirationDateGridColumn;
		internal DevExpress.XtraTab.XtraTabPage receivingReturnXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage adjustmentXtraTabPage;
		internal DevExpress.XtraGrid.GridControl receivingReturnGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView receivingReturnGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingReturnIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnReceivingIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingReturnLotGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingReturnQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingReturnDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingReturnBolGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingReturnExpirationDateGridColumn;
		internal DevExpress.XtraGrid.GridControl adjustmentGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView adjustmentGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn adjustmentIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn adjustmentDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn adjustmentOriginalQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn adjustmentNewQtyGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn adjustmentQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn adjustmentReasonGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit reasonRepositoryItemMemoExEdit;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl2;
		internal DevExpress.XtraGrid.GridControl bomGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView BOMGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn bomIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn FGItemCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn RMItemCodeGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RMRepositoryItemLookUpEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn RMItemDescriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn RMQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn scrapFactorGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteRepositoryItemButtonEdit;
		internal DevExpress.XtraGrid.GridControl poolBomGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView poolBomGridView;
		internal DevExpress.Xpo.XPCollection poolBomXpCollection;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn poolIdGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
		internal DevExpress.XtraGrid.Columns.GridColumn colPoolBomQuantity;
		internal DevExpress.XtraGrid.Columns.GridColumn colScrapFactor;
		internal DevExpress.XtraGrid.Columns.GridColumn poolBomDeleteGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit poolBomDeleteRepositoryItemButtonEdit;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit poolsRepositoryItemLookUpEdit;
		internal DevExpress.Xpo.XPView itemPoolsXpView;
		internal DevExpress.XtraGrid.Views.Grid.GridView poolDetailsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn isPoolGridColumn;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.TextEdit upcTextEdit;
		internal DevExpress.XtraGrid.GridControl inventoryGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView inventoryGridView;
		internal DevExpress.Xpo.XPView inventoryXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colLocationCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colLocationName;
		internal DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		internal DevExpress.XtraGrid.Columns.GridColumn localQuantityOnHandGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn localQuantityYieldsGridColumn;
		internal DevExpress.XtraTab.XtraTabPage transfersXtraTabPage;
		internal DevExpress.XtraGrid.GridControl transfersGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView transfersGridView;
		internal DevExpress.Xpo.XPView transfersXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colFromLocation;
		internal DevExpress.XtraGrid.Columns.GridColumn colToLocation;
		internal DevExpress.XtraGrid.Columns.GridColumn colLot;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferQuantity;
		internal DevExpress.XtraGrid.Columns.GridColumn colUnits;
		internal DevExpress.XtraGrid.Columns.GridColumn colPallets;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemExpirationDate;
		internal DevExpress.XtraEditors.LabelControl LabelControl36;
		internal DevExpress.XtraEditors.TextEdit bagsPerCaseTextEdit;
		internal DevExpress.Xpo.XPView machineLineXpView;
		internal DevExpress.XtraEditors.CheckEdit requiresLotCodeCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit generateLotCodesCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit requiresExpirationDateCheckEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl37;
		internal DevExpress.XtraEditors.LookUpEdit lotCodeFormatLookUpEdit;
		internal DevExpress.Xpo.XPView lotCodeFormatsXpView;
		internal DevExpress.XtraTab.XtraTabPage productionStandardsXtraTabPage;
		internal DevExpress.XtraGrid.GridControl productionStandardsGridControl;
		internal DevExpress.Xpo.XPCollection productionStandardsXpCollection;
		internal DevExpress.XtraGrid.Views.Grid.GridView productionStandardsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid1;
		internal DevExpress.XtraGrid.Columns.GridColumn colHasChanges;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
		internal DevExpress.XtraGrid.Columns.GridColumn colProductionPerMinute;
		internal DevExpress.XtraGrid.Columns.GridColumn colMinutesPerShift;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit machineRepositoryItemLookUpEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn delProdStdGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit delProdStdRepositoryItemButtonEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn colProjectedPackers;
		internal DevExpress.XtraEditors.LabelControl LabelControl38;
		internal DevExpress.XtraEditors.TextEdit minutesPerShiftTextEdit;
		internal DevExpress.Utils.Behaviors.BehaviorManager BehaviorManager1;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingLpnGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingReturnLpnGridColumn;
		internal DevExpress.XtraEditors.LabelControl LabelControl39;
		internal DevExpress.XtraEditors.CheckedComboBoxEdit AllergenInfoCheckedComboBoxEdit;
	}

}