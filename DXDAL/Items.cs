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
                get
                {
                    return fItemID;
                }
                set
                {
                    SetPropertyValue<int>("ItemID", ref fItemID, value);
                }
            }
            private string fItemCode;
            [Size(50)]
            public string ItemCode
            {
                get
                {
                    return fItemCode;
                }
                set
                {
                    SetPropertyValue<string>("ItemCode", ref fItemCode, value);
                }
            }
            private string fItemDescription;
            [Size(1073741823)]
            public string ItemDescription
            {
                get
                {
                    return fItemDescription;
                }
                set
                {
                    SetPropertyValue<string>("ItemDescription", ref fItemDescription, value);
                }
            }
            private string fItemType;
            [Size(50)]
            public string ItemType
            {
                get
                {
                    return fItemType;
                }
                set
                {
                    SetPropertyValue<string>("ItemType", ref fItemType, value);
                }
            }
            private Customers fItemCustomerID;
            public Customers ItemCustomerID
            {
                get
                {
                    return fItemCustomerID;
                }
                set
                {
                    SetPropertyValue<Customers>("ItemCustomerID", ref fItemCustomerID, value);
                }
            }
            private MachineLine fItemDefaultMachine;
            public MachineLine ItemDefaultMachine
            {
                get
                {
                    return fItemDefaultMachine;
                }
                set
                {
                    SetPropertyValue<MachineLine>("ItemDefaultMachine", ref fItemDefaultMachine, value);
                }
            }
            private double? fItemProdStandard;
            public double? ItemProdStandard
            {
                get
                {
                    return fItemProdStandard;
                }
                set
                {
                    SetPropertyValue<double?>("ItemProdStandard", ref fItemProdStandard, value);
                }
            }
            private byte[] fItemPicture;
            public byte[] ItemPicture
            {
                get
                {
                    return fItemPicture;
                }
                set
                {
                    SetPropertyValue<byte[]>("ItemPicture", ref fItemPicture, value);
                }
            }
            private double fdblPrice;
            public double dblPrice
            {
                get
                {
                    return fdblPrice;
                }
                set
                {
                    SetPropertyValue<double>("dblPrice", ref fdblPrice, value);
                }
            }
            private float fsngRebate;
            public float sngRebate
            {
                get
                {
                    return fsngRebate;
                }
                set
                {
                    SetPropertyValue<float>("sngRebate", ref fsngRebate, value);
                }
            }
            private string fstrUnitOfMeasure;
            [Size(50)]
            public string strUnitOfMeasure
            {
                get
                {
                    return fstrUnitOfMeasure;
                }
                set
                {
                    SetPropertyValue<string>("strUnitOfMeasure", ref fstrUnitOfMeasure, value);
                }
            }
            private double fintQtyPerUnit;
            public double intQtyPerUnit
            {
                get
                {
                    return fintQtyPerUnit;
                }
                set
                {
                    SetPropertyValue<double>("intQtyPerUnit", ref fintQtyPerUnit, value);
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
            private double fdblFreight;
            public double dblFreight
            {
                get
                {
                    return fdblFreight;
                }
                set
                {
                    SetPropertyValue<double>("dblFreight", ref fdblFreight, value);
                }
            }
            private double fdblFilm;
            public double dblFilm
            {
                get
                {
                    return fdblFilm;
                }
                set
                {
                    SetPropertyValue<double>("dblFilm", ref fdblFilm, value);
                }
            }
            private double fdblBoxes;
            public double dblBoxes
            {
                get
                {
                    return fdblBoxes;
                }
                set
                {
                    SetPropertyValue<double>("dblBoxes", ref fdblBoxes, value);
                }
            }
            private double fdblStretchWrap;
            public double dblStretchWrap
            {
                get
                {
                    return fdblStretchWrap;
                }
                set
                {
                    SetPropertyValue<double>("dblStretchWrap", ref fdblStretchWrap, value);
                }
            }
            private double fdblPallets;
            public double dblPallets
            {
                get
                {
                    return fdblPallets;
                }
                set
                {
                    SetPropertyValue<double>("dblPallets", ref fdblPallets, value);
                }
            }
            private double fdblOther1;
            public double dblOther1
            {
                get
                {
                    return fdblOther1;
                }
                set
                {
                    SetPropertyValue<double>("dblOther1", ref fdblOther1, value);
                }
            }
            private double fdblOther2;
            public double dblOther2
            {
                get
                {
                    return fdblOther2;
                }
                set
                {
                    SetPropertyValue<double>("dblOther2", ref fdblOther2, value);
                }
            }
            private double fdblOther3;
            public double dblOther3
            {
                get
                {
                    return fdblOther3;
                }
                set
                {
                    SetPropertyValue<double>("dblOther3", ref fdblOther3, value);
                }
            }
            private double fdblOther4;
            public double dblOther4
            {
                get
                {
                    return fdblOther4;
                }
                set
                {
                    SetPropertyValue<double>("dblOther4", ref fdblOther4, value);
                }
            }
            private double fdblOther5;
            public double dblOther5
            {
                get
                {
                    return fdblOther5;
                }
                set
                {
                    SetPropertyValue<double>("dblOther5", ref fdblOther5, value);
                }
            }
            private double fintUnitsPerCase;
            public double intUnitsPerCase
            {
                get
                {
                    return fintUnitsPerCase;
                }
                set
                {
                    SetPropertyValue<double>("intUnitsPerCase", ref fintUnitsPerCase, value);
                }
            }
            private int fintUnitsPerPallet;
            public int intUnitsPerPallet
            {
                get
                {
                    return fintUnitsPerPallet;
                }
                set
                {
                    SetPropertyValue<int>("intUnitsPerPallet", ref fintUnitsPerPallet, value);
                }
            }
            private int fintCasesPerPallet;
            public int intCasesPerPallet
            {
                get
                {
                    return fintCasesPerPallet;
                }
                set
                {
                    SetPropertyValue<int>("intCasesPerPallet", ref fintCasesPerPallet, value);
                }
            }
            private float fsngQuantityOnHand;
            public float sngQuantityOnHand
            {
                get
                {
                    return fsngQuantityOnHand;
                }
                set
                {
                    SetPropertyValue<float>("sngQuantityOnHand", ref fsngQuantityOnHand, value);
                }
            }
            private double fCaseGrossWeight;
            public double CaseGrossWeight
            {
                get
                {
                    return fCaseGrossWeight;
                }
                set
                {
                    SetPropertyValue<double>("CaseGrossWeight", ref fCaseGrossWeight, value);
                }
            }
            private string fPackageCode;
            [Size(400)]
            public string PackageCode
            {
                get
                {
                    return fPackageCode;
                }
                set
                {
                    SetPropertyValue<string>("PackageCode", ref fPackageCode, value);
                }
            }
            private string fCaseCode;
            [Size(400)]
            public string CaseCode
            {
                get
                {
                    return fCaseCode;
                }
                set
                {
                    SetPropertyValue<string>("CaseCode", ref fCaseCode, value);
                }
            }
            private string fRequiredWeight;
            [Size(50)]
            public string RequiredWeight
            {
                get
                {
                    return fRequiredWeight;
                }
                set
                {
                    SetPropertyValue<string>("RequiredWeight", ref fRequiredWeight, value);
                }
            }
            private string fMAV;
            [Size(50)]
            public string MAV
            {
                get
                {
                    return fMAV;
                }
                set
                {
                    SetPropertyValue<string>("MAV", ref fMAV, value);
                }
            }
            private string fCasesPerLayer;
            [Size(50)]
            public string CasesPerLayer
            {
                get
                {
                    return fCasesPerLayer;
                }
                set
                {
                    SetPropertyValue<string>("CasesPerLayer", ref fCasesPerLayer, value);
                }
            }
            private string fLayersPerPallet;
            [Size(50)]
            public string LayersPerPallet
            {
                get
                {
                    return fLayersPerPallet;
                }
                set
                {
                    SetPropertyValue<string>("LayersPerPallet", ref fLayersPerPallet, value);
                }
            }
            private string fShelfLife;
            [Size(50)]
            public string ShelfLife
            {
                get
                {
                    return fShelfLife;
                }
                set
                {
                    SetPropertyValue<string>("ShelfLife", ref fShelfLife, value);
                }
            }
            private string fInstructions;
            [Size(400)]
            public string Instructions
            {
                get
                {
                    return fInstructions;
                }
                set
                {
                    SetPropertyValue<string>("Instructions", ref fInstructions, value);
                }
            }
            private string fPalletPattern;
            [Size(150)]
            public string PalletPattern
            {
                get
                {
                    return fPalletPattern;
                }
                set
                {
                    SetPropertyValue<string>("PalletPattern", ref fPalletPattern, value);
                }
            }
            private bool fInactive;
            public bool Inactive
            {
                get
                {
                    return fInactive;
                }
                set
                {
                    SetPropertyValue<bool>("Inactive", ref fInactive, value);
                }
            }
            private bool fEditing;
            public bool Editing
            {
                get
                {
                    return fEditing;
                }
                set
                {
                    SetPropertyValue<bool>("Editing", ref fEditing, value);
                }
            }
            private double? m_Packers;
            public double? Packers
            {
                get
                {
                    return m_Packers;
                }
                set
                {
                    SetPropertyValue<double?>("Packers", ref m_Packers, value);
                }
            }

            private string fUpc;
            [Size(50)]
            public string UPC
            {
                get
                {
                    return fUpc;
                }
                set
                {
                    SetPropertyValue<string>("UPC", ref fUpc, value);
                }
            }

            private int? fBagsPerCase;
            public int? BagsPerCase
            {
                get
                {
                    return fBagsPerCase;
                }
                set
                {
                    SetPropertyValue<int?>("BagsPerCase", ref fBagsPerCase, value);
                }
            }

            private bool? fGenerateLotCodes;
            public bool? GenerateLotCodes
            {
                get
                {
                    return fGenerateLotCodes;
                }
                set
                {
                    SetPropertyValue<bool?>("GenerateLotCodes", ref fGenerateLotCodes, value);
                }
            }

            private bool? fRequiresLotCodes;
            public bool? RequiresLotCodes
            {
                get
                {
                    return fRequiresLotCodes;
                }
                set
                {
                    SetPropertyValue<bool?>("RequiresLotCodes", ref fRequiresLotCodes, value);
                }
            }

            private bool? fRequiresExpirationDates;
            public bool? RequiresExpirationDates
            {
                get
                {
                    return fRequiresExpirationDates;
                }
                set
                {
                    SetPropertyValue<bool?>("RequiresExpirationDates", ref fRequiresExpirationDates, value);
                }
            }

            private LotCodeFormats fDefaultLotCodeFormat;
            public LotCodeFormats DefaultLotCodeFormat
            {
                get
                {
                    return fDefaultLotCodeFormat;
                }
                set
                {
                    SetPropertyValue("DefaultLotCodeFormat", ref fDefaultLotCodeFormat, value);
                }
            }

            private double fMinutesPerShift;
            public double MinutesPerShift
            {
                get
                {
                    return fMinutesPerShift;
                }
                set
                {
                    SetPropertyValue("MinutesPerShift", ref fMinutesPerShift, value);
                }
            }

            private string fAllergens;
            public string Allergens
            {
                get
                {
                    return fAllergens;
                }
                set
                {
                    SetPropertyValue("Allergens", ref fAllergens, value);
                }
            }


            [Association("Item-BOM", typeof(BOMs))]
            [Aggregated()]
            public XPCollection<BOMs> ItemBOM
            {
                get
                {
                    return GetCollection<BOMs>("ItemBOM");
                }
            }

            [Association("Item-PoolBom", typeof(PoolBom))]
            [Aggregated()]
            public XPCollection<PoolBom> ItemPoolBom
            {
                get
                {
                    return GetCollection<PoolBom>("ItemPoolBom");
                }
            }

            [Association("LocationInventory-Item", typeof(LocationInventory))]
            [Aggregated()]
            public XPCollection<LocationInventory> LocationsInventory
            {
                get
                {
                    return GetCollection<LocationInventory>("LocationsInventory");
                }
            }
            [Association("LocationInventoryByLot-Item", typeof(LocationInventoryByLot))]
            [Aggregated()]
            public XPCollection<LocationInventoryByLot> LocationsInventoryByLot
            {
                get
                {
                    return GetCollection<LocationInventoryByLot>("LocationsInventoryByLot");
                }
            }

            [Association("Transfer-Item", typeof(LocationTransferDetails))]
            [Aggregated()]
            public XPCollection<LocationTransferDetails> LocationTransfers
            {
                get
                {
                    return GetCollection<LocationTransferDetails>("LocationTransfers");
                }
            }

            [PersistentAlias("LocationsInventory.Sum(QuantityOnHand)")]
            public double TotalQuantityOnHand
            {
                get
                {
                    return Convert.ToDouble(EvaluateAlias("TotalQuantityOnHand"));
                }
            }

            [Association("Item-Machines", typeof(ItemMachineStandards))]
            [Aggregated()]
            public XPCollection<ItemMachineStandards> MachineStandards
            {
                get
                {
                    return GetCollection<ItemMachineStandards>("MachineStandards");
                }
            }

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



            public new class FieldsClass : DevExpress.Xpo.PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ItemID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ItemID"));
                    }
                }
                public OperandProperty ItemCode
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ItemCode"));
                    }
                }
                public OperandProperty ItemDescription
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ItemDescription"));
                    }
                }
                public OperandProperty ItemType
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ItemType"));
                    }
                }
                public Customers.FieldsClass ItemCustomerID
                {
                    get
                    {
                        return new Customers.FieldsClass(GetNestedName("ItemCustomerID"));
                    }
                }
                public OperandProperty ItemDefaultMachine
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ItemDefaultMachine"));
                    }
                }
                public OperandProperty ItemProdStandard
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ItemProdStandard"));
                    }
                }
                public OperandProperty ItemPicture
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ItemPicture"));
                    }
                }
                public OperandProperty dblPrice
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblPrice"));
                    }
                }
                public OperandProperty sngRebate
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("sngRebate"));
                    }
                }
                public OperandProperty strUnitOfMeasure
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strUnitOfMeasure"));
                    }
                }
                public OperandProperty intQtyPerUnit
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("intQtyPerUnit"));
                    }
                }
                public OperandProperty strEnteredBy
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strEnteredBy"));
                    }
                }
                public OperandProperty dtmEnteredOn
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dtmEnteredOn"));
                    }
                }
                public OperandProperty dblFreight
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblFreight"));
                    }
                }
                public OperandProperty dblFilm
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblFilm"));
                    }
                }
                public OperandProperty dblBoxes
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblBoxes"));
                    }
                }
                public OperandProperty dblStretchWrap
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblStretchWrap"));
                    }
                }
                public OperandProperty dblPallets
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblPallets"));
                    }
                }
                public OperandProperty dblOther1
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblOther1"));
                    }
                }
                public OperandProperty dblOther2
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblOther2"));
                    }
                }
                public OperandProperty dblOther3
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblOther3"));
                    }
                }
                public OperandProperty dblOther4
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblOther4"));
                    }
                }
                public OperandProperty dblOther5
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblOther5"));
                    }
                }
                public OperandProperty intUnitsPerCase
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("intUnitsPerCase"));
                    }
                }
                public OperandProperty intUnitsPerPallet
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("intUnitsPerPallet"));
                    }
                }
                public OperandProperty intCasesPerPallet
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("intCasesPerPallet"));
                    }
                }
                public OperandProperty sngQuantityOnHand
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("sngQuantityOnHand"));
                    }
                }
                public OperandProperty CaseGrossWeight
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CaseGrossWeight"));
                    }
                }
                public OperandProperty PackageCode
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PackageCode"));
                    }
                }
                public OperandProperty CaseCode
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CaseCode"));
                    }
                }
                public OperandProperty RequiredWeight
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("RequiredWeight"));
                    }
                }
                public OperandProperty MAV
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("MAV"));
                    }
                }
                public OperandProperty CasesPerLayer
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CasesPerLayer"));
                    }
                }
                public OperandProperty LayersPerPallet
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LayersPerPallet"));
                    }
                }
                public OperandProperty ShelfLife
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShelfLife"));
                    }
                }
                public OperandProperty Instructions
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Instructions"));
                    }
                }
                public OperandProperty PalletPattern
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PalletPattern"));
                    }
                }
                public OperandProperty Inactive
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Inactive"));
                    }
                }
                public OperandProperty Editing
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Editing"));
                    }
                }
                public OperandProperty Packers
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Packers"));
                    }
                }
                public OperandProperty UPC
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("UPC"));
                    }
                }
                public OperandProperty TotalQuantityOnHand
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("TotalQuantityOnHand"));
                    }
                }
                public OperandProperty BagsPerCase
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("BagsPerCase"));
                    }
                }
                public OperandProperty GenerateLotCodes
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("GenerateLotCodes"));
                    }
                }
                public OperandProperty RequiresLotCodes
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("RequiresLotCodes"));
                    }
                }
                public OperandProperty RequiresExpirationDates
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("RequiresExpirationDates"));
                    }
                }
                public LotCodeFormats.FieldsClass DefaultLotCodeFormat
                {
                    get
                    {
                        return new LotCodeFormats.FieldsClass(GetNestedName("DefaultLotCodeFormat"));
                    }
                }
                public OperandProperty MinutesPerShift
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("MinutesPerShift"));
                    }
                }
                public OperandProperty Allergens
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Allergens"));
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
