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
                get
                {
                    return fInventoryID;
                }
                set
                {
                    SetPropertyValue<int>("InventoryID", ref fInventoryID, value);
                }
            }
            private DateTime fInventoryDate;
            public DateTime InventoryDate
            {
                get
                {
                    return fInventoryDate;
                }
                set
                {
                    SetPropertyValue<DateTime>("InventoryDate", ref fInventoryDate, value);
                }
            }

            private Items fInventoryItemID;
            public Items InventoryItemID
            {
                get
                {
                    return fInventoryItemID;
                }
                set
                {
                    SetPropertyValue<Items>("InventoryItemID", ref fInventoryItemID, value);
                }
            }
            private int fInventoryQuantity;
            public int InventoryQuantity
            {
                get
                {
                    return fInventoryQuantity;
                }
                set
                {
                    SetPropertyValue<int>("InventoryQuantity", ref fInventoryQuantity, value);
                }
            }
            private float fInventoryPallets;
            public float InventoryPallets
            {
                get
                {
                    return fInventoryPallets;
                }
                set
                {
                    SetPropertyValue<float>("InventoryPallets", ref fInventoryPallets, value);
                }
            }
            private string fstrEnteredBy;
            [Size(50)]
            public string strEnteredBy
            {
                get
                {
                    return fstrEnteredBy;
                }
                set
                {
                    SetPropertyValue<string>("strEnteredBy", ref fstrEnteredBy, value);
                }
            }
            private DateTime fdtmEnteredOn;
            public DateTime dtmEnteredOn
            {
                get
                {
                    return fdtmEnteredOn;
                }
                set
                {
                    SetPropertyValue<DateTime>("dtmEnteredOn", ref fdtmEnteredOn, value);
                }
            }
            private string fPO;
            [Size(50)]
            public string PO
            {
                get
                {
                    return fPO;
                }
                set
                {
                    SetPropertyValue<string>("PO", ref fPO, value);
                }
            }
            private string fLot;
            [Size(150)]
            public string Lot
            {
                get
                {
                    return fLot;
                }
                set
                {
                    SetPropertyValue<string>("Lot", ref fLot, value);
                }
            }
            private Shifts fShift;
            public Shifts Shift
            {
                get
                {
                    return fShift;
                }
                set
                {
                    SetPropertyValue<Shifts>("Shift", ref fShift, value);
                }
            }
            private int? fPallet;
            public int? Pallet
            {
                get
                {
                    return fPallet;
                }
                set
                {
                    SetPropertyValue<int?>("Pallet", ref fPallet, value);
                }
            }
            private int? fLPNNumber;
            public int? LPNNumber
            {
                get
                {
                    return fLPNNumber;
                }
                set
                {
                    SetPropertyValue<int?>("LPNNumber", ref fLPNNumber, value);
                }
            }
            private DateTime? fExpirationDate;
            public DateTime? ExpirationDate
            {
                get
                {
                    return fExpirationDate;
                }
                set
                {
                    if (value < DateTime.Parse("1990-01-01"))
                        value = default(DateTime?);
                    SetPropertyValue<DateTime?>("ExpirationDate", ref fExpirationDate, value);
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
                set
                {
                    SetPropertyValue<string>("FullLPNNumber", ref fFullLPNNumber, value);
                }
            }
            private Shipping fShipment;
            public Shipping Shipment
            {
                get
                {
                    return fShipment;
                }
                set
                {
                    SetPropertyValue<Shipping>("Shipment", ref fShipment, value);
                }
            }
            private Locations fProductionLocation;
            [Association("Production-Location")]
            public Locations ProductionLocation
            {
                get
                {
                    return fProductionLocation;
                }
                set
                {
                    SetPropertyValue<Locations>("ProductionLocation", ref fProductionLocation, value);
                }
            }
            private LocationTransfers fLocationTransfer;
            public LocationTransfers LocationTransfer
            {
                get
                {
                    return fLocationTransfer;
                }
                set
                {
                    SetPropertyValue<LocationTransfers>("LocationTransfer", ref fLocationTransfer, value);
                }
            }
            private string fNote;
            [Size(1073741823)]
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

            [Association("Inventory-Consumption", typeof(BomConsumption))]
            [Aggregated()]
            public XPCollection<BomConsumption> InventoryConsumption
            {
                get
                {
                    return GetCollection<BomConsumption>("InventoryConsumption");
                }
            }

            [Association("ProjectDetails-Production", typeof(ProductionProjectDetails))]
            [Aggregated()]
            public XPCollection<ProductionProjectDetails> ProductionProject
            {
                get
                {
                    return GetCollection<ProductionProjectDetails>("ProductionProject");
                }
            }

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
            public new class FieldsClass : XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty InventoryID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("InventoryID"));
                    }
                }
                public OperandProperty InventoryDate
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("InventoryDate"));
                    }
                }
                public Items.FieldsClass InventoryItemID
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("InventoryItemID"));
                    }
                }
                public OperandProperty InventoryQuantity
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("InventoryQuantity"));
                    }
                }
                public OperandProperty InventoryPallets
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("InventoryPallets"));
                    }
                }
                public const string strEnteredByFieldName = "strEnteredBy";
                public DevExpress.Data.Filtering.OperandProperty strEnteredBy
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("strEnteredBy"));
                    }
                }
                public OperandProperty dtmEnteredOn
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dtmEnteredOn"));
                    }
                }
                public const string POFieldName = "PO";
                public DevExpress.Data.Filtering.OperandProperty PO
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("PO"));
                    }
                }
                public const string LotFieldName = "Lot";
                public DevExpress.Data.Filtering.OperandProperty Lot
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("Lot"));
                    }
                }
                public Shifts.FieldsClass Shift
                {
                    get
                    {
                        return new Shifts.FieldsClass(GetNestedName("Shift"));
                    }
                }
                public OperandProperty Pallet
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Pallet"));
                    }
                }
                public OperandProperty LPNNumber
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LPNNumber"));
                    }
                }
                public OperandProperty ExpirationDate
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ExpirationDate"));
                    }
                }
                public OperandProperty FullLPNNumber
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("FullLPNNumber"));
                    }
                }
                public Shipping.FieldsClass Shipment
                {
                    get
                    {
                        return new Shipping.FieldsClass(GetNestedName("Shipment"));
                    }
                }
                public Locations.FieldsClass ProductionLocation
                {
                    get
                    {
                        return new Locations.FieldsClass(GetNestedName("ProductionLocation"));
                    }
                }
                public LocationTransfers.FieldsClass LocationTransfer
                {
                    get
                    {
                        return new LocationTransfers.FieldsClass(GetNestedName("LocationTransfer"));
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
