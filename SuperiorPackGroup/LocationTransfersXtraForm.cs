using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Xpo.Helpers;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Controls;

namespace SuperiorPackGroup
{
    public partial class LocationTransfersXtraForm
    {

        public LocationTransfersXtraForm()
        {
            InitializeComponent();
        }

        private bool m_CanSaveDetails = true;
        private LocationTransfers m_CurrentTransfer;
        private List<string> m_LPNsInTransfer = new List<string>();
        private Session m_TransfersSession;

        private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            m_CurrentTransfer = new LocationTransfers(m_TransfersSession);
            oidTextEdit.EditValue = m_CurrentTransfer.Oid;
            transferNumberTextEdit.EditValue = null;
            fromLocationLookUpEdit.EditValue = null;
            toLocationLookUpEdit.EditValue = null;
            transferDateDateEdit.DateTime = DateTime.Today;
            carrierLookUpEdit.EditValue = null;
            trailerTextEdit.EditValue = null;
            transferNumberTextEdit.EditValue = null;
            loadedByLookUpEdit.EditValue = null;
            unloadedByLookUpEdit.EditValue = null;
            checkedByLookUpEdit.EditValue = null;

            transferDetailsXpCollection.Criteria = new BinaryOperator(LocationTransferDetails.Fields.Transfer.Oid.PropertyName, m_CurrentTransfer.Oid, BinaryOperatorType.Equal);
            transferDetailsXpCollection.Reload();

            fromLocationLookUpEdit.Enabled = true;
            toLocationLookUpEdit.Enabled = true;

            Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, false);
            transferDetailsGridView.OptionsBehavior.Editable = true;
            transferSearchGridControl.Enabled = false;
            CheckPermissions();

            EnableAvailableBarButtons(true);

        }

        private void cancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            CancelChanges();
            CheckPermissions();

            Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, true);
            transferDetailsGridView.OptionsBehavior.Editable = false;
            transferSearchGridControl.Enabled = true;

            EnableAvailableBarButtons(false);

        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (transferDetailsXpCollection.Count > 0)
            {
                MessageBox.Show("You must delete first the details.", "Detlete Transfer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this transfer.", "Delete Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                return;
            }

            try
            {
                m_CurrentTransfer.Delete();
                if (m_CurrentTransfer.IsDeleted)
                {
                    BindTransferSearch();
                }
                else
                {
                    MessageBox.Show("The Transfer was not deleted.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("The Transfer was not deleted.{0}{1}", Environment.NewLine, ex.Message), "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteRepositoryItemButtonEdit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to remove this transfer detail, this can`t be undone?", "Delete Transfer Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                return;
            }

            LocationTransferDetails detail = m_TransfersSession.GetObjectByKey<LocationTransferDetails>(transferDetailsGridView.GetFocusedRowCellValue(colOid));
            if (detail != null)
            {
                int item = Convert.ToInt32(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn));

                if (detail.TransferQuantity > ItemsBLL.GetQtyOnHandByID(m_TransfersSession,item, Convert.ToInt32(toLocationLookUpEdit.EditValue), detail.TransferLot,detail.FullLpnNumber))
                {
                    MessageBox.Show("You can't delete this transfer detail, it will create a negative stock at the location", "Insufficient Inventory", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                detail.Delete();
                if (detail.IsDeleted == false)
                {
                    MessageBox.Show("The transfer detail was not removed.");
                }
                else
                {
                    LocationInventoryBLL.UpdateStock(m_TransfersSession, item, Convert.ToInt32(fromLocationLookUpEdit.EditValue), detail.TransferQuantity,detail.TransferLot,detail.FullLpnNumber);
                    LocationInventoryBLL.UpdateStock(m_TransfersSession, item, Convert.ToInt32(toLocationLookUpEdit.EditValue), detail.TransferQuantity *-1, detail.TransferLot, detail.FullLpnNumber);
                }
            }
            else
            {
                transferDetailsGridView.DeleteRow(transferDetailsGridView.FocusedRowHandle);
            }

        }

        private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (m_CurrentTransfer == null)
            {
                MessageBox.Show("Please select a location transfer to edit.");
                return;
            }

            Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, false);
            transferDetailsGridView.OptionsBehavior.Editable = true;
            transferSearchGridControl.Enabled = false;
            CheckPermissions();

            EnableAvailableBarButtons(true);

        }

        private void fromLocationLookUpEdit_Validated(object sender, EventArgs e)
        {

            BindItemLookupEdit();

        }

        private void LocationTransfersXtraForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (transferSearchGridControl.Enabled == false)
            {
                switch (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        if (SaveChanges() == false)
                        {
                            e.Cancel = true;
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = false;
                        break;
                    case DialogResult.No:
                        CancelChanges();
                        break;
                }
            }

            if (e.Cancel == false)
            {
                XPBaseObject.AutoSaveOnEndEdit = true;
                m_TransfersSession.PurgeDeletedObjects();
            }

        }

        private void LocationTransfersXtraForm_Load(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;

            CheckPermissions();

            m_TransfersSession = new Session(MyDataLayers.SPGDataLayer);
            m_TransfersSession.TrackPropertiesModifications = true;
            m_TransfersSession.OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException;

            for (int i = 0; i < components.Components.Count; i++)
            {
                if ((components.Components[i]) is XPView)
                {
                    ((XPView)components.Components[i]).Session = m_TransfersSession;
                }
                else if ((components.Components[i]) is XPCollection)
                {
                    ((XPCollection)components.Components[i]).Session = m_TransfersSession;
                }
            }

            transferDetailsXpCollection.Criteria = new BinaryOperator(LocationTransferDetails.Fields.Transfer.Oid.PropertyName, 0, BinaryOperatorType.Equal);
            transferSearchGridView.OptionsBehavior.Editable = false;

            XPBaseObject.AutoSaveOnEndEdit = false;

            Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, true);
            //lpnNumberTextEdit.Properties.ReadOnly = True

            Cursor = Cursors.Default;

        }

        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (SaveChanges())
            {
                CheckPermissions();

                Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, true);
                transferDetailsGridView.OptionsBehavior.Editable = false;
                transferSearchGridControl.Enabled = true;

                EnableAvailableBarButtons(false);
            }

        }

        private void transferDetailsGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if ((transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn) == null) || Convert.IsDBNull(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn)))
            {
                return;
            }

            FilterLpns();
            FilterLots();

            if (e.Column == colTransferLot && e.Value != null)
            {
                float qty = 0;
                qty = ItemsBLL.GetQtyOnHandByID(m_TransfersSession, (int?)transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn), (int)fromLocationLookUpEdit.EditValue, (string)transferDetailsGridView.GetFocusedRowCellValue(colTransferLot), (int?)transferDetailsGridView.GetFocusedRowCellValue(fullLpnNumberGridColumn));
                transferDetailsGridView.SetFocusedRowCellValue(colTransferQuantity, qty);
            }

            if (e.Column == transferItemGridColumn || e.Column == colTransferQuantity || e.Column == colTransferUnits)
            {
                if (Convert.ToDouble(transferDetailsGridView.GetFocusedRowCellValue(colTransferQuantity)) > 0 || Convert.ToDouble(transferDetailsGridView.GetFocusedRowCellValue(colTransferUnits)) > 0)
                {
                    UpdatePallets();
                }
            }

        }

        private void transferDetailsGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            transferDetailsGridView.SetRowCellValue(e.RowHandle, transferIDGridColumn, m_CurrentTransfer.Oid);
            FilterLpns();
            FilterLots();
        }

        private void transferDetailsGridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {

            e.ExceptionMode = ExceptionMode.NoAction;
            transferDetailsGridView.FocusedColumn = colTransferQuantity;

        }

        private void transferDetailsGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            Items item = null;
            string lot = null;
            int LPNNumber = 0;

            item = Session.DefaultSession.GetObjectByKey<Items>(Convert.ToInt32(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn)), true);
            lot = (transferDetailsGridView.GetFocusedRowCellValue(colTransferLot) == null ? null : Convert.ToString(transferDetailsGridView.GetFocusedRowCellValue(colTransferLot)));

            LPNNumber = Convert.ToInt32(transferDetailsGridView.GetFocusedRowCellValue(fullLpnNumberGridColumn));
            if (LPNNumber == 0)
            {
                MessageBox.Show("LPN Number is invalid", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                e.Valid = false;
                m_CanSaveDetails = false;
                return;
            }

            try
            {
                if (!LotCodeValidator.ValidateByItem(item, lot, false))
                {
                    throw new ApplicationException("Item " + item.ItemCode + " & lot # " + lot + " is invalid" + Environment.NewLine + "You must provide a valid lot.");
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                e.Valid = false;
                m_CanSaveDetails = false;
                return;
            }

            double stock = Convert.ToDouble(((ViewRecord)itemRepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn)))[2]); //QuantityOnHand
            double lotStock = ItemsBLL.GetQtyOnHandByIDAndLot(m_TransfersSession, item.ItemID, Convert.ToInt32(fromLocationLookUpEdit.EditValue), lot, LPNNumber);

            double transferingQuantity = 0;
            if (Convert.ToInt32(transferDetailsGridView.GetRowCellValue(e.RowHandle, colOid)) < 1)
            {
                transferingQuantity = Convert.ToDouble(transferDetailsGridView.GetRowCellValue(e.RowHandle, colTransferQuantity));
            }
            else
            {
                transferingQuantity = Convert.ToDouble(transferDetailsGridView.GetRowCellValue(e.RowHandle, colTransferQuantity)) - Session.DefaultSession.GetObjectByKey<LocationTransferDetails>(transferDetailsGridView.GetRowCellValue(e.RowHandle, colOid), true).TransferQuantity;
            }

            if (stock < transferingQuantity)
            {
                MessageBox.Show(string.Format("{0} does only have {1} in stock and your transfering {2}.", transferDetailsGridView.GetRowCellDisplayText(e.RowHandle, transferItemGridColumn).ToString(), stock.ToString(), transferingQuantity.ToString()), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                e.Valid = false;
                m_CanSaveDetails = false;
            }
            else if (lotStock < transferingQuantity)
            {
                MessageBox.Show($"{item.ItemCode} lot# {lot} LPN# {LPNNumber} does only have {lotStock} in stock and your transfering {transferingQuantity}.", "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                e.Valid = false;
                m_CanSaveDetails = false;
            }
            else
            {
                m_CanSaveDetails = true;
            }

        }

        private void transferSearchGridView_Click(object sender, EventArgs e)
        {

            if (transferSearchGridView.FocusedRowHandle == -999997)
            {
                return;
            }

            if (transferSearchGridView.CalcHitInfo(transferSearchGridControl.PointToClient(Control.MousePosition)).HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                BindTransferControls(Convert.ToInt32(transferSearchGridView.GetFocusedRowCellValue(colTransferID)));
            }

        }

        private void BindItemLookupEdit()
        {
            itemXpView.Criteria = new BinaryOperator(LocationInventory.Fields.Location.Oid.PropertyName, Convert.ToInt32(fromLocationLookUpEdit.EditValue), BinaryOperatorType.Equal);
            itemXpView.Reload();

            FilterLpns();
            FilterLots();

        }

        private void BindTransferControls(int LocationTransferID)
        {

            m_TransfersSession.DropIdentityMap();

            LocationTransfers transfer = m_TransfersSession.GetObjectByKey<LocationTransfers>(LocationTransferID, true);
            m_CurrentTransfer = transfer;
            oidTextEdit.EditValue = m_CurrentTransfer.Oid;
            fromLocationLookUpEdit.EditValue = m_CurrentTransfer.FromLocation?.Oid;
            toLocationLookUpEdit.EditValue = m_CurrentTransfer.ToLocation?.Oid;
            transferDateDateEdit.DateTime = m_CurrentTransfer.TransferDate;
            carrierLookUpEdit.EditValue = m_CurrentTransfer.TransferCarrier?.CarrierID;
            trailerTextEdit.EditValue = m_CurrentTransfer.Trailer;
            transferNumberTextEdit.EditValue = m_CurrentTransfer.TransferNumber;
            loadedByLookUpEdit.EditValue = m_CurrentTransfer.LoadedBy?.Oid;
            unloadedByLookUpEdit.EditValue = m_CurrentTransfer.UnloadedBy?.Oid;
            checkedByLookUpEdit.EditValue = m_CurrentTransfer.CheckedBy?.Oid;

            transferDetailsXpCollection.Criteria = new BinaryOperator(LocationTransferDetails.Fields.Transfer.Oid.PropertyName, m_CurrentTransfer.Oid, BinaryOperatorType.Equal);
            transferDetailsXpCollection.Reload();

            BindItemLookupEdit();

        }

        private void BindTransferSearch()
        {

            transferSearchXpView.Reload();

        }

        private void CancelChanges()
        {

            if (m_CurrentTransfer.Oid != -1)
            {
                BindTransferControls(m_CurrentTransfer.Oid);
            }

        }

        public bool CheckPermissions()
        {

            try
            {
                SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Shipping Form")[0];

                switch (permission.PermissionLevel)
                {
                    case "FULL":
                    case "Full":
                        addBarButtonItem.Enabled = true;
                        editBarButtonItem.Enabled = true;
                        deleteBarButtonItem.Enabled = true;
                        delGridColumn.Visible = true;
                        delGridColumn.VisibleIndex = 0;
                        break;
                    case "ADD":
                    case "Add":
                        addBarButtonItem.Enabled = true;
                        editBarButtonItem.Enabled = true;
                        deleteBarButtonItem.Enabled = false;
                        delGridColumn.Visible = false;
                        break;
                    case "NONE":
                    case "None":
                        MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        Close();
                        return false;
                    case "VIEW":
                    case "View":
                        addBarButtonItem.Enabled = false;
                        editBarButtonItem.Enabled = false;
                        deleteBarButtonItem.Enabled = false;
                        delGridColumn.Visible = false;
                        break;
                    case "EDIT":
                    case "Edit":
                        addBarButtonItem.Enabled = false;
                        editBarButtonItem.Enabled = true;
                        deleteBarButtonItem.Enabled = false;
                        delGridColumn.Visible = false;
                        break;
                    default:
                        MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                        return false;
                }
                return true;
            }
            catch (InvalidOperationException ex)
            {
                return false;
            }

        }

        private void EnableAvailableBarButtons(bool editingMode)
        {

            if (editingMode)
            {
                cancelBarButtonItem.Enabled = true;
                saveBarButtonItem.Enabled = true;
                deleteRepositoryItemButtonEdit.Buttons[0].Enabled = true;
                editBarButtonItem.Enabled = false;
                addBarButtonItem.Enabled = false;
                deleteBarButtonItem.Enabled = false;
                refreshBarButtonItem.Enabled = false;
            }
            else
            {
                refreshBarButtonItem.Enabled = true;
                cancelBarButtonItem.Enabled = false;
                saveBarButtonItem.Enabled = false;
                deleteRepositoryItemButtonEdit.Buttons[0].Enabled = false;
                fromLocationLookUpEdit.Enabled = false;
                toLocationLookUpEdit.Enabled = false;
            }

        }

        private bool SaveChanges()
        {

            int selectedID = 0;

            //make sure that the record gets validated before saving by moving off the record being edited
            transferDetailsGridView.CloseEditor();
            transferDetailsGridView.MoveNext();

            if (m_CanSaveDetails == false || ValidateAvailability() == false)
            {
                return false;
            }

            if (m_CurrentTransfer.Oid != -1)
            {
                selectedID = transferSearchGridView.FocusedRowHandle;
            }

            if (LocationTransfersBLL.ValidateRecord((int?)transferNumberTextEdit.EditValue, (int?)fromLocationLookUpEdit.EditValue, (int?)toLocationLookUpEdit.EditValue, (int?)carrierLookUpEdit.EditValue, m_CurrentTransfer, m_TransfersSession))
            {
                m_CurrentTransfer.FromLocation = m_TransfersSession.GetObjectByKey<Locations>(Convert.ToInt32(fromLocationLookUpEdit.EditValue));
                m_CurrentTransfer.ToLocation = m_TransfersSession.GetObjectByKey<Locations>(Convert.ToInt32(toLocationLookUpEdit.EditValue));
                m_CurrentTransfer.TransferDate = Convert.ToDateTime(transferDateDateEdit.DateTime);
                m_CurrentTransfer.TransferCarrier = m_TransfersSession.GetObjectByKey<Carriers>(Convert.ToInt32(carrierLookUpEdit.EditValue));
                m_CurrentTransfer.Trailer = (trailerTextEdit.EditValue == null) ? null : (trailerTextEdit.EditValue == null ? null : Convert.ToString(trailerTextEdit.EditValue));
                //m_CurrentTransfer.TransferNumber = CInt(transferNumberTextEdit.EditValue)
                m_CurrentTransfer.LoadedBy = (loadedByLookUpEdit.EditValue == null) ? null : m_TransfersSession.GetObjectByKey<Employees>(Convert.ToInt32(loadedByLookUpEdit.EditValue));
                m_CurrentTransfer.UnloadedBy = (unloadedByLookUpEdit.EditValue == null) ? null : m_TransfersSession.GetObjectByKey<Employees>(Convert.ToInt32(unloadedByLookUpEdit.EditValue));
                m_CurrentTransfer.CheckedBy = (checkedByLookUpEdit.EditValue == null) ? null : m_TransfersSession.GetObjectByKey<Employees>(Convert.ToInt32(checkedByLookUpEdit.EditValue));
            }
            else
            {
                MessageBox.Show("You must provide a From location; To location and Carrier before saving the record.");
                return false;
            }

            try
            {
                int newQuantity = 0;
                LocationTransferDetails originalRecord = null;

                foreach (LocationTransferDetails transferDetail in transferDetailsXpCollection)
                {
                    if (transferDetail.Transfer == null || transferDetail.Transfer.Oid == -1)
                    {
                        transferDetail.Transfer = m_CurrentTransfer;
                        LocationInventoryBLL.UpdateStock(m_TransfersSession, transferDetail.TransferItem.ItemID, Convert.ToInt32(fromLocationLookUpEdit.EditValue), transferDetail.TransferQuantity * -1, transferDetail.TransferLot, transferDetail.FullLpnNumber);
                        LocationInventoryBLL.UpdateStock(m_TransfersSession, transferDetail.TransferItem.ItemID, Convert.ToInt32(toLocationLookUpEdit.EditValue), transferDetail.TransferQuantity, transferDetail.TransferLot, transferDetail.FullLpnNumber);
                    }
                    else
                    {
                        originalRecord = Session.DefaultSession.GetObjectByKey<LocationTransferDetails>(transferDetail.Oid, true);

                        if (originalRecord == null)
                        {
                            newQuantity = transferDetail.TransferQuantity;
                        }
                        else
                        {
                            newQuantity = transferDetail.TransferQuantity - originalRecord.TransferQuantity;
                        }

                        LocationInventoryBLL.UpdateStock(m_TransfersSession, transferDetail.TransferItem.ItemID, Convert.ToInt32(fromLocationLookUpEdit.EditValue), newQuantity * -1, transferDetail.TransferLot, transferDetail.FullLpnNumber);
                        LocationInventoryBLL.UpdateStock(m_TransfersSession, transferDetail.TransferItem.ItemID, Convert.ToInt32(toLocationLookUpEdit.EditValue), newQuantity, transferDetail.TransferLot, transferDetail.FullLpnNumber);
                    }
                }
                m_CurrentTransfer.Save();
                
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            BindTransferSearch();
            BindTransferControls(m_CurrentTransfer.Oid);
            transferSearchGridView.FocusedRowHandle = selectedID;
            return true;

        }

        public void UpdatePallets()
        {

            double units = ItemsBLL.GetCaseQuantity(Convert.ToInt32(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn)));
            float pallets = Convert.ToSingle(((ViewRecord)itemRepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn)))[3]); //CasesPerPallet

            if (Convert.ToDouble(transferDetailsGridView.GetFocusedRowCellValue(colTransferQuantity)) < 1)
            {
                if (units != 0)
                {
                    transferDetailsGridView.SetFocusedRowCellValue(colTransferQuantity, Convert.ToDouble(transferDetailsGridView.GetFocusedRowCellValue(colTransferUnits)) * units);
                }
                else
                {
                    transferDetailsGridView.SetFocusedRowCellValue(colTransferQuantity, 0);
                }
            }

            //calculate the quantity
            if (Convert.ToDouble(transferDetailsGridView.GetFocusedRowCellValue(colTransferUnits)) == 0)
            {
                if (units != 0)
                {
                    transferDetailsGridView.SetFocusedRowCellValue(colTransferUnits, Math.Ceiling(Convert.ToDouble(transferDetailsGridView.GetFocusedRowCellValue(colTransferQuantity)) / units));
                }
            }

            if (pallets != 0)
            {
                transferDetailsGridView.SetFocusedRowCellValue(colTransferPallets, Convert.ToDouble(transferDetailsGridView.GetFocusedRowCellValue(colTransferUnits)) / pallets);
            }
            else
            {
                transferDetailsGridView.SetFocusedRowCellValue(colTransferPallets, 0);
            }

        }

        private bool ValidateAvailability()
        {
            Dictionary<int, double> totalTransferQuantity = new Dictionary<int, double>();
            double stock = 0;

            if (transferDetailsGridView.GroupCount == 0)
            {
                for (int i = 0; i < transferDetailsGridView.RowCount; i++)
                {
                    if (transferDetailsGridView.IsValidRowHandle(i))
                    {
                        if (ValidateAvailabilityByLine(i, totalTransferQuantity) == false)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                int i = -1;
                while (transferDetailsGridView.IsValidRowHandle(i))
                {
                    if (transferDetailsGridView.GetChildRowHandle(i, 0) > -1)
                    {
                        //INSTANT C# NOTE: The ending condition of VB 'For' loops is tested only on entry to the loop. Instant C# has created a temporary variable in order to use the initial value of transferDetailsGridView.GetChildRowCount(i) + transferDetailsGridView.GetChildRowHandle(i, 0) for every iteration:
                        int tempVar = transferDetailsGridView.GetChildRowCount(i) + transferDetailsGridView.GetChildRowHandle(i, 0);
                        for (int ci = transferDetailsGridView.GetChildRowHandle(i, 0); ci < tempVar; ci++)
                        {
                            if (ValidateAvailabilityByLine(ci, totalTransferQuantity) == false)
                            {
                                return false;
                            }
                        }
                    }
                    i -= 1;
                }
            }

            foreach (int product in totalTransferQuantity.Keys)
            {
                stock = ItemsBLL.GetQtyOnHandByID(m_TransfersSession, product, Convert.ToInt32(fromLocationLookUpEdit.EditValue));
                if (stock < totalTransferQuantity[product])
                {
                    MessageBox.Show(string.Format("{0} does only have {1} in stock and your shipping {2}.{3}You must enter first the production.", Session.DefaultSession.GetObjectByKey<Items>(product).ItemCode, stock.ToString(), totalTransferQuantity[product].ToString(), Environment.NewLine), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
            }

            return true;

        }

        private bool ValidateAvailabilityByLine(int i, Dictionary<int, double> totalTransferQuantity)
        {

            double stock = 0;
            double lotStock = 0;
            int transferQuantity = 0;
            Items item = null;
            string lot = null;
            int LPNNumber = 0;

            lot = (transferDetailsGridView.GetRowCellValue(i, colTransferLot) == null ? null : Convert.ToString(transferDetailsGridView.GetRowCellValue(i, colTransferLot)));
            item = Session.DefaultSession.GetObjectByKey<Items>(Convert.ToInt32(transferDetailsGridView.GetRowCellValue(i, transferItemGridColumn)), true);
            LPNNumber = Convert.ToInt32(transferDetailsGridView.GetRowCellValue(i, fullLpnNumberGridColumn));
            if (LPNNumber == 0)
            {
                MessageBox.Show("LPN Number is invalid", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            try
            {
                if (!LotCodeValidator.ValidateByItem(item, lot, false))
                {
                    throw new ApplicationException("Item " + item.ItemCode + " & lot # " + lot + " is invalid" + Environment.NewLine + "You must provide a valid lot.");
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            stock = ItemsBLL.GetQtyOnHandByID(m_TransfersSession, Convert.ToInt32(transferDetailsGridView.GetRowCellValue(i, transferItemGridColumn)), Convert.ToInt32(fromLocationLookUpEdit.EditValue));

            lotStock = ItemsBLL.GetQtyOnHandByIDAndLot(m_TransfersSession, Convert.ToInt32(transferDetailsGridView.GetRowCellValue(i, transferItemGridColumn)), Convert.ToInt32(fromLocationLookUpEdit.EditValue), lot, LPNNumber);

            if (m_TransfersSession.IsNewObject(transferDetailsGridView.GetRow(i)) == false && ((LocationTransferDetails)transferDetailsGridView.GetRow(i)).HasChanges == false)
            {
                return true;
            }
            else if (m_TransfersSession.IsNewObject(transferDetailsGridView.GetRow(i)) == false)
            {
                transferQuantity = Convert.ToInt32(transferDetailsGridView.GetRowCellValue(i, colTransferQuantity)) - Session.DefaultSession.GetObjectByKey<LocationTransferDetails>(transferDetailsGridView.GetRowCellValue(i, colOid), true).TransferQuantity;
            }
            else
            {
                transferQuantity = Convert.ToInt32(transferDetailsGridView.GetRowCellValue(i, colTransferQuantity));
            }

            if (stock < transferQuantity)
            {
                MessageBox.Show($"{item.ItemCode} does only have {stock} in stock and your shipping {transferQuantity}.{Environment.NewLine}You must enter first the production.", "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            if (lotStock < transferQuantity)
            {
                MessageBox.Show($"{item.ItemCode} lot# {lot} LPN# {LPNNumber} does only have {lotStock} in stock and your shipping {transferQuantity}.{Environment.NewLine}You must enter first the production.", "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            if (totalTransferQuantity.ContainsKey(Convert.ToInt32(transferDetailsGridView.GetRowCellValue(i, transferItemGridColumn))))
            {
                totalTransferQuantity[Convert.ToInt32(transferDetailsGridView.GetRowCellValue(i, transferItemGridColumn))] += transferQuantity;
            }
            else
            {
                totalTransferQuantity.Add(Convert.ToInt32(transferDetailsGridView.GetRowCellValue(i, transferItemGridColumn)), transferQuantity);
            }

            return true;
        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            m_TransfersSession.DropIdentityMap();
            locationsXpView.Reload();
            employeesXpView.Reload();
            carrierXpView.Reload();
            transferDetailsXpCollection.Reload();
            transferSearchXpView.Reload();
            transferDetailsXpCollection.Reload();
            itemXpView.Reload();

        }

        private void lpnNumberTextEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (fromLocationLookUpEdit.EditValue != null && lpnNumberTextEdit.Text.Length > 0)
            {
                int LocationID = Convert.ToInt32(fromLocationLookUpEdit.EditValue);

                try
                {
                    int LPN = int.Parse(lpnNumberTextEdit.Text.Replace(CustomersBLL.GetLPNPrefix(7), ""));

                    for (int i = 0; i < transferDetailsGridView.RowCount; i++)
                    {
                        if (transferDetailsGridView.GetDataRow(i) != null && transferDetailsGridView.GetDataRow(i)["FullLpnNumber"].Equals(LPN))
                        {
                            MessageBox.Show("This LPN is already entered.");
                            lpnNumberTextEdit.EditValue = null;
                            return;
                        }
                    }

                    foreach (LocationInventoryByLot record in new XPCollection<LocationInventoryByLot>(m_TransfersSession, new GroupOperator(new BinaryOperator(LocationInventoryByLot.Fields.LPNNumber, LPN, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, LocationID, BinaryOperatorType.Equal))))
                    {
                        transferDetailsGridView.AddNewRow();
                        transferDetailsGridView.SetRowCellValue(transferDetailsGridView.FocusedRowHandle, transferItemGridColumn, record.LocationInventoryItem.ItemID);
                        transferDetailsGridView.SetRowCellValue(transferDetailsGridView.FocusedRowHandle, colTransferQuantity, record.QuantityOnHand);
                        transferDetailsGridView.SetRowCellValue(transferDetailsGridView.FocusedRowHandle, colTransferLot, record.LocationInventoryLot);
                        transferDetailsGridView.SetRowCellValue(transferDetailsGridView.FocusedRowHandle, colItemExpirationDate, record.ExpirationDate);
                        transferDetailsGridView.SetRowCellValue(transferDetailsGridView.FocusedRowHandle, fullLpnNumberGridColumn, LPN);
                        transferDetailsGridView.UpdateCurrentRow();
                    }
                }
                catch
                {
                }
                lpnNumberTextEdit.EditValue = null;
            }
        }

        private void FilterLpns()
        {
            CriteriaOperatorCollection lpnViewCriteria = new CriteriaOperatorCollection();

            if (fromLocationLookUpEdit.EditValue != null)
                lpnViewCriteria.Add(new BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, Convert.ToInt32(fromLocationLookUpEdit.EditValue), BinaryOperatorType.Equal));
            
                lpnViewCriteria.Add(new BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryItem.ItemID.PropertyName, transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn), BinaryOperatorType.Equal));

                LPNxpView.Criteria = CriteriaOperator.And(lpnViewCriteria);
            
        }
        private void FilterLots()
        {

            CriteriaOperatorCollection lotViewCriteria = new CriteriaOperatorCollection();

            if (fromLocationLookUpEdit.EditValue != null)
                lotViewCriteria.Add(new BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, Convert.ToInt32(fromLocationLookUpEdit.EditValue), BinaryOperatorType.Equal));

            lotViewCriteria.Add(new BinaryOperator(LocationInventoryByLot.Fields.LPNNumber.PropertyName, transferDetailsGridView.GetFocusedRowCellValue(fullLpnNumberGridColumn), BinaryOperatorType.Equal));

            LotXpView.Criteria = CriteriaOperator.And(lotViewCriteria);
            LotXpView.Reload();
        }

        private void transferDetailsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bool isEdit = (int?)transferDetailsGridView.GetFocusedRowCellValue(colOid) > 0;

                itemRepositoryItemLookUpEdit.ReadOnly = isEdit;
                LotRepositoryItemLookUpEdit.ReadOnly = isEdit;
                lpnRepositoryItemLookUpEdit.ReadOnly = isEdit;
        }
    }
}