using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class PoolBom : AuditableBase
        {
            private ItemPool fItemPoolId;
            public ItemPool ItemPoolID
            {
                get
                {
                    return fItemPoolId;
                }
                set
                {
                    SetPropertyValue<ItemPool>("ItemPoolID", ref fItemPoolId, value);
                }
            }
            private Items fPoolBomFiniGoodID;
            [Association("Item-PoolBom")]
            public Items PoolBomFiniGoodID
            {
                get
                {
                    return fPoolBomFiniGoodID;
                }
                set
                {
                    SetPropertyValue<Items>("PoolBomFiniGoodID", ref fPoolBomFiniGoodID, value);
                }
            }
            private float fPoolBomQuantity;
            public float PoolBomQuantity
            {
                get
                {
                    return fPoolBomQuantity;
                }
                set
                {
                    SetPropertyValue<float>("PoolBomQuantity", ref fPoolBomQuantity, value);
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

            public PoolBom() : base()
            {
            }

            public PoolBom(Session session) : base(session)
            {
            }

            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }

            private static FieldsClass _Fields;
            public static new FieldsClass Fields
            {
                get
                {
                    if (ReferenceEquals(_Fields, null))
                        _Fields = new FieldsClass();
                    return _Fields;
                }
            }

            public new class FieldsClass : DevExpress.Xpo.XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }

                public ItemPool.FieldsClass ItemPoolID
                {
                    get
                    {
                        return new ItemPool.FieldsClass(GetNestedName("ItemPoolID"));
                    }
                }
                public Items.FieldsClass PoolBomFiniGoodID
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("PoolBomFiniGoodID"));
                    }
                }
                public OperandProperty PoolBomQuantity
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PoolBomQuantity"));
                    }
                }
                public OperandProperty ScrapFactor
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ScrapFactor"));
                    }
                }
            }
        }
    }
}
