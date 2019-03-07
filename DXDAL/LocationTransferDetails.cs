using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class LocationTransferDetails : AuditableBase
        {
            private LocationTransfers fTransfer;
            [Association("Transfer-Details")]
            public LocationTransfers Transfer
            {
                get => fTransfer;
                set => SetPropertyValue("Transfer", ref fTransfer, value);
            }

            private Items fTransferItem;
            [Association("Transfer-Item")]
            public Items TransferItem
            {
                get => fTransferItem;
                set => SetPropertyValue("TransferItem", ref fTransferItem, value);
            }

            private string fTransferlot;
            [Size(150)]
            public string TransferLot
            {
                get => fTransferlot;
                set => SetPropertyValue("Transferlot", ref fTransferlot, value);
            }

            private int fTransferQuantity;
            public int TransferQuantity
            {
                get => fTransferQuantity;
                set => SetPropertyValue<int>("TransferQuantity", ref fTransferQuantity, value);
            }

            private int? fTransferUnits;
            public int? TransferUnits
            {
                get => fTransferUnits;
                set => SetPropertyValue("TransferUnits", ref fTransferUnits, value);
            }

            private float fTransferPallets;
            public float TransferPallets
            {
                get => fTransferPallets;
                set => SetPropertyValue("TransferPallets", ref fTransferPallets, value);
            }

            private DateTime fItemExpirationDate;
            public DateTime ItemExpirationDate
            {
                get => fItemExpirationDate;
                set => SetPropertyValue<DateTime>("ItemExpirationDate", ref fItemExpirationDate, value);
            }

            private int? fFullLpnNumber;
            public int? FullLpnNumber
            {
                get => fFullLpnNumber;
                set => SetPropertyValue("FullLpnNumber", ref fFullLpnNumber, value);
            }

            private string fNote;
            public string Note
            {
                get => fNote;
                set => SetPropertyValue("Note", ref fNote, value);
            }

            public LocationTransferDetails() : base()
            {
            }

            public LocationTransferDetails(Session session) : base(session)
            {
            }

            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }

            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public LocationTransfers.FieldsClass Transfer => new LocationTransfers.FieldsClass(GetNestedName("Transfer"));
                public Items.FieldsClass TransferItem => new Items.FieldsClass(GetNestedName("TransferItem"));
                public OperandProperty TransferLot => new OperandProperty(GetNestedName("TransferLot"));
                public OperandProperty TransferQuantity => new OperandProperty(GetNestedName("TransferQuantity"));
                public OperandProperty TransferUnits => new OperandProperty(GetNestedName("TransferUnits"));
                public OperandProperty TransferPallets => new OperandProperty(GetNestedName("TransferPallets"));
                public OperandProperty ItemExpirationDate => new OperandProperty(GetNestedName("ItemExpirationDate"));
                public OperandProperty FullLpnNumber => new OperandProperty(GetNestedName("FullLpnNumber"));
                public OperandProperty Note => new OperandProperty(GetNestedName("Note"));
            }
            private static FieldsClass _fields;
            public static new FieldsClass Fields
            {
                get
                {
                    if (ReferenceEquals(_fields, null))
                        _fields = new FieldsClass();
                    return _fields;
                }
            }
        }
    }
}
