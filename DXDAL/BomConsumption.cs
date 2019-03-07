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
                get => fRawMatID;
                set => SetPropertyValue("RawMatID", ref fRawMatID, value);
            }
            private Inventory fInventoryID;
            [Association("Inventory-Consumption")]
            public Inventory InventoryID
            {
                get => fInventoryID;
                set => SetPropertyValue("InventoryID", ref fInventoryID, value);
            }
            private float fQuantityUsed;
            public float QuantityUsed
            {
                get => fQuantityUsed;
                set => SetPropertyValue("QuantityUsed", ref fQuantityUsed, value);
            }
            private double fScrapFactorUsed;
            public double ScrapFactorUsed
            {
                get => fScrapFactorUsed;
                set => SetPropertyValue("ScrapFactorUsed", ref fScrapFactorUsed, value);
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

            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public Items.FieldsClass RawMatID => new Items.FieldsClass(GetNestedName("RawMatID"));
                public Inventory.FieldsClass InventoryID => new Inventory.FieldsClass(GetNestedName("InventoryID"));
                public DevExpress.Data.Filtering.OperandProperty QuantityUsed => new DevExpress.Data.Filtering.OperandProperty(GetNestedName("QuantityUsed"));
                public DevExpress.Data.Filtering.OperandProperty ScrapFactorUsed => new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ScrapFactorUsed"));
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
