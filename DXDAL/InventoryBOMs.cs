using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblInventoryBOMs")]
        public class InventoryBOMs : XPLiteObject
        {
            private int fInventoryBOMID;
            [Key(true)]
            public int InventoryBOMID
            {
                get => fInventoryBOMID;
                set => SetPropertyValue<int>("InventoryBOMID", ref fInventoryBOMID, value);
            }
            private Items fInventoryBOMRawMatID;
            public Items InventoryBOMRawMatID
            {
                get => fInventoryBOMRawMatID;
                set => SetPropertyValue("InventoryBOMRawMatID", ref fInventoryBOMRawMatID, value);
            }
            private Inventory fInventoryBOMInventoryID;
            public Inventory InventoryBOMInventoryID
            {
                get => fInventoryBOMInventoryID;
                set => SetPropertyValue("InventoryBOMInventoryID", ref fInventoryBOMInventoryID, value);
            }
            private float fInventoryBOMQuantity;
            public float InventoryBOMQuantity
            {
                get => fInventoryBOMQuantity;
                set => SetPropertyValue("InventoryBOMQuantity", ref fInventoryBOMQuantity, value);
            }
            private double fScrapFactor;
            public double ScrapFactor
            {
                get => fScrapFactor;
                set => SetPropertyValue("ScrapFactor", ref fScrapFactor, value);
            }
            public InventoryBOMs(Session session) : base(session)
            {
            }
            public InventoryBOMs() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }
            // Created/Updated: Joel-PC\Joel on JOEL-PC at 11/04/10 12:07 PM
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public DevExpress.Data.Filtering.OperandProperty InventoryBOMID => new DevExpress.Data.Filtering.OperandProperty(GetNestedName("InventoryBOMID"));
                public Items.FieldsClass InventoryBOMRawMatID => new Items.FieldsClass(GetNestedName("InventoryBOMRawMatID"));
                public Inventory.FieldsClass InventoryBOMInventoryID => new Inventory.FieldsClass(GetNestedName("InventoryBOMInventoryID"));
                public DevExpress.Data.Filtering.OperandProperty InventoryBOMQuantity => new DevExpress.Data.Filtering.OperandProperty(GetNestedName("InventoryBOMQuantity"));
                public DevExpress.Data.Filtering.OperandProperty ScrapFactor => new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ScrapFactor"));
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
