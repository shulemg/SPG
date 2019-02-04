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
                get
                {
                    return fInventoryBOMID;
                }
                set
                {
                    SetPropertyValue<int>("InventoryBOMID", ref fInventoryBOMID, value);
                }
            }
            private Items fInventoryBOMRawMatID;
            public Items InventoryBOMRawMatID
            {
                get
                {
                    return fInventoryBOMRawMatID;
                }
                set
                {
                    SetPropertyValue<Items>("InventoryBOMRawMatID", ref fInventoryBOMRawMatID, value);
                }
            }
            private Inventory fInventoryBOMInventoryID;
            public Inventory InventoryBOMInventoryID
            {
                get
                {
                    return fInventoryBOMInventoryID;
                }
                set
                {
                    SetPropertyValue<Inventory>("InventoryBOMInventoryID", ref fInventoryBOMInventoryID, value);
                }
            }
            private float fInventoryBOMQuantity;
            public float InventoryBOMQuantity
            {
                get
                {
                    return fInventoryBOMQuantity;
                }
                set
                {
                    SetPropertyValue<float>("InventoryBOMQuantity", ref fInventoryBOMQuantity, value);
                }
            }
            private double fScrapFactor;
            public double ScrapFactor
            {
                get
                {
                    return fScrapFactor;
                }
                set
                {
                    SetPropertyValue<double>("ScrapFactor", ref fScrapFactor, value);
                }
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
            public new class FieldsClass : DevExpress.Xpo.XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public DevExpress.Data.Filtering.OperandProperty InventoryBOMID
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("InventoryBOMID"));
                    }
                }
                public Items.FieldsClass InventoryBOMRawMatID
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("InventoryBOMRawMatID"));
                    }
                }
                public Inventory.FieldsClass InventoryBOMInventoryID
                {
                    get
                    {
                        return new Inventory.FieldsClass(GetNestedName("InventoryBOMInventoryID"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty InventoryBOMQuantity
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("InventoryBOMQuantity"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty ScrapFactor
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ScrapFactor"));
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
