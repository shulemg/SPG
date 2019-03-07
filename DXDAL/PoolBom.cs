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
                get => fItemPoolId;
                set => SetPropertyValue("ItemPoolID", ref fItemPoolId, value);
            }
            private Items fPoolBomFiniGoodID;
            [Association("Item-PoolBom")]
            public Items PoolBomFiniGoodID
            {
                get => fPoolBomFiniGoodID;
                set => SetPropertyValue("PoolBomFiniGoodID", ref fPoolBomFiniGoodID, value);
            }
            private float fPoolBomQuantity;
            public float PoolBomQuantity
            {
                get => fPoolBomQuantity;
                set => SetPropertyValue("PoolBomQuantity", ref fPoolBomQuantity, value);
            }
            private double fScrapFactor;
            public double ScrapFactor
            {
                get => fScrapFactor;
                set => SetPropertyValue("ScrapFactor", ref fScrapFactor, value);
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

            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }

                public ItemPool.FieldsClass ItemPoolID => new ItemPool.FieldsClass(GetNestedName("ItemPoolID"));
                public Items.FieldsClass PoolBomFiniGoodID => new Items.FieldsClass(GetNestedName("PoolBomFiniGoodID"));
                public OperandProperty PoolBomQuantity => new OperandProperty(GetNestedName("PoolBomQuantity"));
                public OperandProperty ScrapFactor => new OperandProperty(GetNestedName("ScrapFactor"));
            }
        }
    }
}
