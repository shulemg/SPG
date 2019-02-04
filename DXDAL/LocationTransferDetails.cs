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
                get
                {
                    return fTransfer;
                }
                set
                {
                    SetPropertyValue<LocationTransfers>("Transfer", ref fTransfer, value);
                }
            }

            private Items fTransferItem;
            [Association("Transfer-Item")]
            public Items TransferItem
            {
                get
                {
                    return fTransferItem;
                }
                set
                {
                    SetPropertyValue<Items>("TransferItem", ref fTransferItem, value);
                }
            }

            private string fTransferlot;
            [Size(150)]
            public string TransferLot
            {
                get
                {
                    return fTransferlot;
                }
                set
                {
                    SetPropertyValue<string>("Transferlot", ref fTransferlot, value);
                }
            }

            private int fTransferQuantity;
            public int TransferQuantity
            {
                get
                {
                    return fTransferQuantity;
                }
                set
                {
                    SetPropertyValue<int>("TransferQuantity", ref fTransferQuantity, value);
                }
            }

            private int? fTransferUnits;
            public int? TransferUnits
            {
                get
                {
                    return fTransferUnits;
                }
                set
                {
                    SetPropertyValue<int?>("TransferUnits", ref fTransferUnits, value);
                }
            }

            private float fTransferPallets;
            public float TransferPallets
            {
                get
                {
                    return fTransferPallets;
                }
                set
                {
                    SetPropertyValue<float>("TransferPallets", ref fTransferPallets, value);
                }
            }

            private DateTime fItemExpirationDate;
            public DateTime ItemExpirationDate
            {
                get
                {
                    return fItemExpirationDate;
                }
                set
                {
                    SetPropertyValue<DateTime>("ItemExpirationDate", ref fItemExpirationDate, value);
                }
            }

            private int? fFullLpnNumber;
            public int? FullLpnNumber
            {
                get
                {
                    return fFullLpnNumber;
                }
                set
                {
                    SetPropertyValue<int?>("FullLpnNumber", ref fFullLpnNumber, value);
                }
            }

            private string fNote;
            public string Note
            {
                get
                {
                    return fNote;
                }
                set
                {
                    SetPropertyValue<string>("Note", ref fNote, value);
                }
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

            public new class FieldsClass : DevExpress.Xpo.PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public LocationTransfers.FieldsClass Transfer
                {
                    get
                    {
                        return new LocationTransfers.FieldsClass(GetNestedName("Transfer"));
                    }
                }
                public Items.FieldsClass TransferItem
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("TransferItem"));
                    }
                }
                public OperandProperty TransferLot
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("TransferLot"));
                    }
                }
                public OperandProperty TransferQuantity
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("TransferQuantity"));
                    }
                }
                public OperandProperty TransferUnits
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("TransferUnits"));
                    }
                }
                public OperandProperty TransferPallets
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("TransferPallets"));
                    }
                }
                public OperandProperty ItemExpirationDate
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ItemExpirationDate"));
                    }
                }
                public OperandProperty FullLpnNumber
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("FullLpnNumber"));
                    }
                }
                public OperandProperty Note
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Note"));
                    }
                }
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
