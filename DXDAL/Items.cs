using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblItems")]
        public class Items : XPLiteObject
        {
            private int fItemID;
            [Key()]
            public int ItemID
            {
                get => fItemID;
                set => SetPropertyValue<int>("ItemID", ref fItemID, value);
            }
            private string fItemCode;
            [Size(50)]
            public string ItemCode
            {
                get => fItemCode;
                set => SetPropertyValue("ItemCode", ref fItemCode, value);
            }
            private string fItemDescription;
            [Size(1073741823)]
            public string ItemDescription
            {
                get => fItemDescription;
                set => SetPropertyValue("ItemDescription", ref fItemDescription, value);
            }
            private string fItemType;
            [Size(50)]
            public string ItemType
            {
                get => fItemType;
                set => SetPropertyValue("ItemType", ref fItemType, value);
            }
            private Customers fItemCustomerID;
            public Customers ItemCustomerID
            {
                get => fItemCustomerID;
                set => SetPropertyValue("ItemCustomerID", ref fItemCustomerID, value);
            }
            private MachineLine fItemDefaultMachine;
            public MachineLine ItemDefaultMachine
            {
                get => fItemDefaultMachine;
                set => SetPropertyValue("ItemDefaultMachine", ref fItemDefaultMachine, value);
            }
            private double? fItemProdStandard;
            public double? ItemProdStandard
            {
                get => fItemProdStandard;
                set => SetPropertyValue("ItemProdStandard", ref fItemProdStandard, value);
            }
            private byte[] fItemPicture;
            public byte[] ItemPicture
            {
                get => fItemPicture;
                set => SetPropertyValue("ItemPicture", ref fItemPicture, value);
            }
            private double fdblPrice;
            public double dblPrice
            {
                get => fdblPrice;
                set => SetPropertyValue("dblPrice", ref fdblPrice, value);
            }
            private float fsngRebate;
            public float sngRebate
            {
                get => fsngRebate;
                set => SetPropertyValue("sngRebate", ref fsngRebate, value);
            }
            private string fstrUnitOfMeasure;
            [Size(50)]
            public string strUnitOfMeasure
            {
                get => fstrUnitOfMeasure;
                set => SetPropertyValue("strUnitOfMeasure", ref fstrUnitOfMeasure, value);
            }
            private double fintQtyPerUnit;
            public double intQtyPerUnit
            {
                get => fintQtyPerUnit;
                set => SetPropertyValue("intQtyPerUnit", ref fintQtyPerUnit, value);
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
            private double fdblFreight;
            public double dblFreight
            {
                get => fdblFreight;
                set => SetPropertyValue("dblFreight", ref fdblFreight, value);
            }
            private double fdblFilm;
            public double dblFilm
            {
                get => fdblFilm;
                set => SetPropertyValue("dblFilm", ref fdblFilm, value);
            }
            private double fdblBoxes;
            public double dblBoxes
            {
                get => fdblBoxes;
                set => SetPropertyValue("dblBoxes", ref fdblBoxes, value);
            }
            private double fdblStretchWrap;
            public double dblStretchWrap
            {
                get => fdblStretchWrap;
                set => SetPropertyValue("dblStretchWrap", ref fdblStretchWrap, value);
            }
            private double fdblPallets;
            public double dblPallets
            {
                get => fdblPallets;
                set => SetPropertyValue("dblPallets", ref fdblPallets, value);
            }
            private double fdblOther1;
            public double dblOther1
            {
                get => fdblOther1;
                set => SetPropertyValue("dblOther1", ref fdblOther1, value);
            }
            private double fdblOther2;
            public double dblOther2
            {
                get => fdblOther2;
                set => SetPropertyValue("dblOther2", ref fdblOther2, value);
            }
            private double fdblOther3;
            public double dblOther3
            {
                get => fdblOther3;
                set => SetPropertyValue("dblOther3", ref fdblOther3, value);
            }
            private double fdblOther4;
            public double dblOther4
            {
                get => fdblOther4;
                set => SetPropertyValue("dblOther4", ref fdblOther4, value);
            }
            private double fdblOther5;
            public double dblOther5
            {
                get => fdblOther5;
                set => SetPropertyValue("dblOther5", ref fdblOther5, value);
            }
            private double fintUnitsPerCase;
            public double intUnitsPerCase
            {
                get => fintUnitsPerCase;
                set => SetPropertyValue("intUnitsPerCase", ref fintUnitsPerCase, value);
            }
            private int fintUnitsPerPallet;
            public int intUnitsPerPallet
            {
                get => fintUnitsPerPallet;
                set => SetPropertyValue<int>("intUnitsPerPallet", ref fintUnitsPerPallet, value);
            }
            private int fintCasesPerPallet;
            public int intCasesPerPallet
            {
                get => fintCasesPerPallet;
                set => SetPropertyValue<int>("intCasesPerPallet", ref fintCasesPerPallet, value);
            }
            private float fsngQuantityOnHand;
            public float sngQuantityOnHand
            {
                get => fsngQuantityOnHand;
                set => SetPropertyValue("sngQuantityOnHand", ref fsngQuantityOnHand, value);
            }
            private double fCaseGrossWeight;
            public double CaseGrossWeight
            {
                get => fCaseGrossWeight;
                set => SetPropertyValue("CaseGrossWeight", ref fCaseGrossWeight, value);
            }
            private string fPackageCode;
            [Size(400)]
            public string PackageCode
            {
                get => fPackageCode;
                set => SetPropertyValue("PackageCode", ref fPackageCode, value);
            }
            private string fCaseCode;
            [Size(400)]
            public string CaseCode
            {
                get => fCaseCode;
                set => SetPropertyValue("CaseCode", ref fCaseCode, value);
            }
            private string fRequiredWeight;
            [Size(50)]
            public string RequiredWeight
            {
                get => fRequiredWeight;
                set => SetPropertyValue("RequiredWeight", ref fRequiredWeight, value);
            }
            private string fMAV;
            [Size(50)]
            public string MAV
            {
                get => fMAV;
                set => SetPropertyValue("MAV", ref fMAV, value);
            }
            private string fCasesPerLayer;
            [Size(50)]
            public string CasesPerLayer
            {
                get => fCasesPerLayer;
                set => SetPropertyValue("CasesPerLayer", ref fCasesPerLayer, value);
            }
            private string fLayersPerPallet;
            [Size(50)]
            public string LayersPerPallet
            {
                get => fLayersPerPallet;
                set => SetPropertyValue("LayersPerPallet", ref fLayersPerPallet, value);
            }
            private string fShelfLife;
            [Size(50)]
            public string ShelfLife
            {
                get => fShelfLife;
                set => SetPropertyValue("ShelfLife", ref fShelfLife, value);
            }
            private string fInstructions;
            [Size(400)]
            public string Instructions
            {
                get => fInstructions;
                set => SetPropertyValue("Instructions", ref fInstructions, value);
            }
            private string fPalletPattern;
            [Size(150)]
            public string PalletPattern
            {
                get => fPalletPattern;
                set => SetPropertyValue("PalletPattern", ref fPalletPattern, value);
            }
            private bool fInactive;
            public bool Inactive
            {
                get => fInactive;
                set => SetPropertyValue("Inactive", ref fInactive, value);
            }
            private bool fEditing;
            public bool Editing
            {
                get => fEditing;
                set => SetPropertyValue("Editing", ref fEditing, value);
            }
            private double? m_Packers;
            public double? Packers
            {
                get => m_Packers;
                set => SetPropertyValue("Packers", ref m_Packers, value);
            }

            private string fUpc;
            [Size(50)]
            public string UPC
            {
                get => fUpc;
                set => SetPropertyValue("UPC", ref fUpc, value);
            }

            private int? fBagsPerCase;
            public int? BagsPerCase
            {
                get => fBagsPerCase;
                set => SetPropertyValue("BagsPerCase", ref fBagsPerCase, value);
            }

            private bool? fGenerateLotCodes;
            public bool? GenerateLotCodes
            {
                get => fGenerateLotCodes;
                set => SetPropertyValue("GenerateLotCodes", ref fGenerateLotCodes, value);
            }

            private bool? fRequiresLotCodes;
            public bool? RequiresLotCodes
            {
                get => fRequiresLotCodes;
                set => SetPropertyValue("RequiresLotCodes", ref fRequiresLotCodes, value);
            }

            private bool? fRequiresExpirationDates;
            public bool? RequiresExpirationDates
            {
                get => fRequiresExpirationDates;
                set => SetPropertyValue("RequiresExpirationDates", ref fRequiresExpirationDates, value);
            }

            private LotCodeFormats fDefaultLotCodeFormat;
            public LotCodeFormats DefaultLotCodeFormat
            {
                get => fDefaultLotCodeFormat;
                set => SetPropertyValue("DefaultLotCodeFormat", ref fDefaultLotCodeFormat, value);
            }

            private double fMinutesPerShift;
            public double MinutesPerShift
            {
                get => fMinutesPerShift;
                set => SetPropertyValue("MinutesPerShift", ref fMinutesPerShift, value);
            }

            private string fAllergens;
            public string Allergens
            {
                get => fAllergens;
                set => SetPropertyValue("Allergens", ref fAllergens, value);
            }


            [Association("Item-BOM", typeof(BOMs))]
            [Aggregated()]
            public XPCollection<BOMs> ItemBOM => GetCollection<BOMs>("ItemBOM");

            [Association("Item-PoolBom", typeof(PoolBom))]
            [Aggregated()]
            public XPCollection<PoolBom> ItemPoolBom => GetCollection<PoolBom>("ItemPoolBom");

            [Association("LocationInventory-Item", typeof(LocationInventory))]
            [Aggregated()]
            public XPCollection<LocationInventory> LocationsInventory => GetCollection<LocationInventory>("LocationsInventory");
            [Association("LocationInventoryByLot-Item", typeof(LocationInventoryByLot))]
            [Aggregated()]
            public XPCollection<LocationInventoryByLot> LocationsInventoryByLot => GetCollection<LocationInventoryByLot>("LocationsInventoryByLot");

            [Association("Transfer-Item", typeof(LocationTransferDetails))]
            [Aggregated()]
            public XPCollection<LocationTransferDetails> LocationTransfers => GetCollection<LocationTransferDetails>("LocationTransfers");

            [PersistentAlias("LocationsInventory.Sum(QuantityOnHand)")]
            public double TotalQuantityOnHand => Convert.ToDouble(EvaluateAlias("TotalQuantityOnHand"));

            [Association("Item-Machines", typeof(ItemMachineStandards))]
            [Aggregated()]
            public XPCollection<ItemMachineStandards> MachineStandards => GetCollection<ItemMachineStandards>("MachineStandards");

            public Items(Session session) : base(session)
            {
            }
            public Items() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }

            public override string ToString()
            {
                return string.Format("{0} - {1}", ItemID, ItemCode);
            }



            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ItemID => new OperandProperty(GetNestedName("ItemID"));
                public OperandProperty ItemCode => new OperandProperty(GetNestedName("ItemCode"));
                public OperandProperty ItemDescription => new OperandProperty(GetNestedName("ItemDescription"));
                public OperandProperty ItemType => new OperandProperty(GetNestedName("ItemType"));
                public Customers.FieldsClass ItemCustomerID => new Customers.FieldsClass(GetNestedName("ItemCustomerID"));
                public OperandProperty ItemDefaultMachine => new OperandProperty(GetNestedName("ItemDefaultMachine"));
                public OperandProperty ItemProdStandard => new OperandProperty(GetNestedName("ItemProdStandard"));
                public OperandProperty ItemPicture => new OperandProperty(GetNestedName("ItemPicture"));
                public OperandProperty dblPrice => new OperandProperty(GetNestedName("dblPrice"));
                public OperandProperty sngRebate => new OperandProperty(GetNestedName("sngRebate"));
                public OperandProperty strUnitOfMeasure => new OperandProperty(GetNestedName("strUnitOfMeasure"));
                public OperandProperty intQtyPerUnit => new OperandProperty(GetNestedName("intQtyPerUnit"));
                public OperandProperty strEnteredBy => new OperandProperty(GetNestedName("strEnteredBy"));
                public OperandProperty dtmEnteredOn => new OperandProperty(GetNestedName("dtmEnteredOn"));
                public OperandProperty dblFreight => new OperandProperty(GetNestedName("dblFreight"));
                public OperandProperty dblFilm => new OperandProperty(GetNestedName("dblFilm"));
                public OperandProperty dblBoxes => new OperandProperty(GetNestedName("dblBoxes"));
                public OperandProperty dblStretchWrap => new OperandProperty(GetNestedName("dblStretchWrap"));
                public OperandProperty dblPallets => new OperandProperty(GetNestedName("dblPallets"));
                public OperandProperty dblOther1 => new OperandProperty(GetNestedName("dblOther1"));
                public OperandProperty dblOther2 => new OperandProperty(GetNestedName("dblOther2"));
                public OperandProperty dblOther3 => new OperandProperty(GetNestedName("dblOther3"));
                public OperandProperty dblOther4 => new OperandProperty(GetNestedName("dblOther4"));
                public OperandProperty dblOther5 => new OperandProperty(GetNestedName("dblOther5"));
                public OperandProperty intUnitsPerCase => new OperandProperty(GetNestedName("intUnitsPerCase"));
                public OperandProperty intUnitsPerPallet => new OperandProperty(GetNestedName("intUnitsPerPallet"));
                public OperandProperty intCasesPerPallet => new OperandProperty(GetNestedName("intCasesPerPallet"));
                public OperandProperty sngQuantityOnHand => new OperandProperty(GetNestedName("sngQuantityOnHand"));
                public OperandProperty CaseGrossWeight => new OperandProperty(GetNestedName("CaseGrossWeight"));
                public OperandProperty PackageCode => new OperandProperty(GetNestedName("PackageCode"));
                public OperandProperty CaseCode => new OperandProperty(GetNestedName("CaseCode"));
                public OperandProperty RequiredWeight => new OperandProperty(GetNestedName("RequiredWeight"));
                public OperandProperty MAV => new OperandProperty(GetNestedName("MAV"));
                public OperandProperty CasesPerLayer => new OperandProperty(GetNestedName("CasesPerLayer"));
                public OperandProperty LayersPerPallet => new OperandProperty(GetNestedName("LayersPerPallet"));
                public OperandProperty ShelfLife => new OperandProperty(GetNestedName("ShelfLife"));
                public OperandProperty Instructions => new OperandProperty(GetNestedName("Instructions"));
                public OperandProperty PalletPattern => new OperandProperty(GetNestedName("PalletPattern"));
                public OperandProperty Inactive => new OperandProperty(GetNestedName("Inactive"));
                public OperandProperty Editing => new OperandProperty(GetNestedName("Editing"));
                public OperandProperty Packers => new OperandProperty(GetNestedName("Packers"));
                public OperandProperty UPC => new OperandProperty(GetNestedName("UPC"));
                public OperandProperty TotalQuantityOnHand => new OperandProperty(GetNestedName("TotalQuantityOnHand"));
                public OperandProperty BagsPerCase => new OperandProperty(GetNestedName("BagsPerCase"));
                public OperandProperty GenerateLotCodes => new OperandProperty(GetNestedName("GenerateLotCodes"));
                public OperandProperty RequiresLotCodes => new OperandProperty(GetNestedName("RequiresLotCodes"));
                public OperandProperty RequiresExpirationDates => new OperandProperty(GetNestedName("RequiresExpirationDates"));
                public LotCodeFormats.FieldsClass DefaultLotCodeFormat => new LotCodeFormats.FieldsClass(GetNestedName("DefaultLotCodeFormat"));
                public OperandProperty MinutesPerShift => new OperandProperty(GetNestedName("MinutesPerShift"));
                public OperandProperty Allergens => new OperandProperty(GetNestedName("Allergens"));
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
