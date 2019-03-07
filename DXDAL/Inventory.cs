using Microsoft.VisualBasic;
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblInventory")]
        public class Inventory : XPLiteObject
        {
            private int fInventoryID;
            [Key(false)]
            public int InventoryID
            {
                get => fInventoryID;
                set => SetPropertyValue<int>("InventoryID", ref fInventoryID, value);
            }
            private DateTime fInventoryDate;
            public DateTime InventoryDate
            {
                get => fInventoryDate;
                set => SetPropertyValue<DateTime>("InventoryDate", ref fInventoryDate, value);
            }

            private Items fInventoryItemID;
            public Items InventoryItemID
            {
                get => fInventoryItemID;
                set => SetPropertyValue("InventoryItemID", ref fInventoryItemID, value);
            }
            private int fInventoryQuantity;
            public int InventoryQuantity
            {
                get => fInventoryQuantity;
                set => SetPropertyValue<int>("InventoryQuantity", ref fInventoryQuantity, value);
            }
            private float fInventoryPallets;
            public float InventoryPallets
            {
                get => fInventoryPallets;
                set => SetPropertyValue("InventoryPallets", ref fInventoryPallets, value);
            }
            private string fstrEnteredBy;
            [Size(50)]
            public string strEnteredBy
            {
                get => fstrEnteredBy;
                set => SetPropertyValue("strEnteredBy", ref fstrEnteredBy, value);
            }
            private DateTime fdtmEnteredOn;
            public DateTime dtmEnteredOn
            {
                get => fdtmEnteredOn;
                set => SetPropertyValue<DateTime>("dtmEnteredOn", ref fdtmEnteredOn, value);
            }
            private string fPO;
            [Size(50)]
            public string PO
            {
                get => fPO;
                set => SetPropertyValue("PO", ref fPO, value);
            }
            private string fLot;
            [Size(150)]
            public string Lot
            {
                get => fLot;
                set => SetPropertyValue("Lot", ref fLot, value);
            }
            private Shifts fShift;
            public Shifts Shift
            {
                get => fShift;
                set => SetPropertyValue("Shift", ref fShift, value);
            }
            private int? fPallet;
            public int? Pallet
            {
                get => fPallet;
                set => SetPropertyValue("Pallet", ref fPallet, value);
            }
            private int? fLPNNumber;
            public int? LPNNumber
            {
                get => fLPNNumber;
                set => SetPropertyValue("LPNNumber", ref fLPNNumber, value);
            }
            private DateTime? fExpirationDate;
            public DateTime? ExpirationDate
            {
                get => fExpirationDate;
                set
                {
                    if (value < DateTime.Parse("1990-01-01"))
                        value = default(DateTime?);
                    SetPropertyValue("ExpirationDate", ref fExpirationDate, value);
                }
            }
            private string fFullLPNNumber;
            public string FullLPNNumber
            {
                get
                {
                    if (string.IsNullOrEmpty(fFullLPNNumber) && LPNNumber.HasValue && LPNNumber.Value > 0)
                        return InventoryItemID.ItemCustomerID.LPNPrefix + ("0000000000" + LPNNumber.Value.ToString()).Substring(InventoryItemID.ItemCustomerID.LastLPNNumber.ToString().Length);
                    else
                        return fFullLPNNumber;
                }
                set => SetPropertyValue("FullLPNNumber", ref fFullLPNNumber, value);
            }
            private Shipping fShipment;
            public Shipping Shipment
            {
                get => fShipment;
                set => SetPropertyValue("Shipment", ref fShipment, value);
            }
            private Locations fProductionLocation;
            [Association("Production-Location")]
            public Locations ProductionLocation
            {
                get => fProductionLocation;
                set => SetPropertyValue("ProductionLocation", ref fProductionLocation, value);
            }
            private LocationTransfers fLocationTransfer;
            public LocationTransfers LocationTransfer
            {
                get => fLocationTransfer;
                set => SetPropertyValue("LocationTransfer", ref fLocationTransfer, value);
            }
            private string fNote;
            [Size(1073741823)]
            public string Note
            {
                get => fNote;
                set => SetPropertyValue("Note", ref fNote, value);
            }

            [Association("Inventory-Consumption", typeof(BomConsumption))]
            [Aggregated()]
            public XPCollection<BomConsumption> InventoryConsumption => GetCollection<BomConsumption>("InventoryConsumption");

            [Association("ProjectDetails-Production", typeof(ProductionProjectDetails))]
            [Aggregated()]
            public XPCollection<ProductionProjectDetails> ProductionProject => GetCollection<ProductionProjectDetails>("ProductionProject");

            public Inventory(Session session) : base(session)
            {
            }
            public Inventory() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }
            // Created/Updated: Joel-PC\Joel on JOEL-PC at 3/10/2013 5:17 PM
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty InventoryID => new OperandProperty(GetNestedName("InventoryID"));
                public OperandProperty InventoryDate => new OperandProperty(GetNestedName("InventoryDate"));
                public Items.FieldsClass InventoryItemID => new Items.FieldsClass(GetNestedName("InventoryItemID"));
                public OperandProperty InventoryQuantity => new OperandProperty(GetNestedName("InventoryQuantity"));
                public OperandProperty InventoryPallets => new OperandProperty(GetNestedName("InventoryPallets"));
                public const string strEnteredByFieldName = "strEnteredBy";
                public OperandProperty strEnteredBy => new OperandProperty(GetNestedName("strEnteredBy"));
                public OperandProperty dtmEnteredOn => new OperandProperty(GetNestedName("dtmEnteredOn"));
                public const string POFieldName = "PO";
                public OperandProperty PO => new OperandProperty(GetNestedName("PO"));
                public const string LotFieldName = "Lot";
                public OperandProperty Lot => new OperandProperty(GetNestedName("Lot"));
                public Shifts.FieldsClass Shift => new Shifts.FieldsClass(GetNestedName("Shift"));
                public OperandProperty Pallet => new OperandProperty(GetNestedName("Pallet"));
                public OperandProperty LPNNumber => new OperandProperty(GetNestedName("LPNNumber"));
                public OperandProperty ExpirationDate => new OperandProperty(GetNestedName("ExpirationDate"));
                public OperandProperty FullLPNNumber => new OperandProperty(GetNestedName("FullLPNNumber"));
                public Shipping.FieldsClass Shipment => new Shipping.FieldsClass(GetNestedName("Shipment"));
                public Locations.FieldsClass ProductionLocation => new Locations.FieldsClass(GetNestedName("ProductionLocation"));
                public LocationTransfers.FieldsClass LocationTransfer => new LocationTransfers.FieldsClass(GetNestedName("LocationTransfer"));
                public OperandProperty Note => new OperandProperty(GetNestedName("Note"));
            }
            public static new FieldsClass Fields
            {
                get
                {
                    if (ReferenceEquals(_Fields, null))
                        _Fields = new FieldsClass();
                    return _Fields;
                }
            }
            private static FieldsClass _Fields;
        }
    }
}
