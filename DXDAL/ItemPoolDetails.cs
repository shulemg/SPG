using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class ItemPoolDetails : AuditableBase
        {
            private ItemPool _itemPoolID;
            private Items _itemID;
            private double _itemPoolRatio;

            [Association("ItemPool-Details")]
            public ItemPool ItemPoolID
            {
                get
                {
                    return _itemPoolID;
                }
                set
                {
                    SetPropertyValue<ItemPool>("ItemPoolID", ref _itemPoolID, value);
                }
            }

            public Items ItemID
            {
                get
                {
                    return _itemID;
                }
                set
                {
                    SetPropertyValue<Items>("ItemID", ref _itemID, value);
                }
            }

            public double ItemPoolRatio
            {
                get
                {
                    return _itemPoolRatio;
                }
                set
                {
                    SetPropertyValue<double>("ItemPoolRatio", ref _itemPoolRatio, value);
                }
            }

            public double QuantityOnHand
            {
                get
                {
                    return ItemID.TotalQuantityOnHand * ItemPoolRatio;
                }
            }

            public ItemPoolDetails() : base()
            {
            }

            public ItemPoolDetails(Session session) : base(session)
            {
            }

            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }

            public new class FieldsClass : DevExpress.Xpo.PersistentBase.FieldsClass
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
                public Items.FieldsClass ItemID
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("ItemID"));
                    }
                }
                public OperandProperty ItemPoolRatio
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ItemPoolRatio"));
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
