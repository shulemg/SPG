using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        public class BomConsumption : AuditableBase
        {
            private Items fRawMatID;
            public Items RawMatID
            {
                get
                {
                    return fRawMatID;
                }
                set
                {
                    SetPropertyValue<Items>("RawMatID", ref fRawMatID, value);
                }
            }
            private Inventory fInventoryID;
            [Association("Inventory-Consumption")]
            public Inventory InventoryID
            {
                get
                {
                    return fInventoryID;
                }
                set
                {
                    SetPropertyValue<Inventory>("InventoryID", ref fInventoryID, value);
                }
            }
            private float fQuantityUsed;
            public float QuantityUsed
            {
                get
                {
                    return fQuantityUsed;
                }
                set
                {
                    SetPropertyValue<float>("QuantityUsed", ref fQuantityUsed, value);
                }
            }
            private double fScrapFactorUsed;
            public double ScrapFactorUsed
            {
                get
                {
                    return fScrapFactorUsed;
                }
                set
                {
                    SetPropertyValue<double>("ScrapFactorUsed", ref fScrapFactorUsed, value);
                }
            }

            public BomConsumption() : base()
            {
            }

            public BomConsumption(Session session) : base(session)
            {
            }

            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }

            public new class FieldsClass : XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public Items.FieldsClass RawMatID
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("RawMatID"));
                    }
                }
                public Inventory.FieldsClass InventoryID
                {
                    get
                    {
                        return new Inventory.FieldsClass(GetNestedName("InventoryID"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty QuantityUsed
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("QuantityUsed"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty ScrapFactorUsed
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ScrapFactorUsed"));
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
