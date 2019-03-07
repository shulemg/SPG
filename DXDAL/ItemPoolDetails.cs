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
                get => _itemPoolID;
                set => SetPropertyValue("ItemPoolID", ref _itemPoolID, value);
            }

            public Items ItemID
            {
                get => _itemID;
                set => SetPropertyValue("ItemID", ref _itemID, value);
            }

            public double ItemPoolRatio
            {
                get => _itemPoolRatio;
                set => SetPropertyValue("ItemPoolRatio", ref _itemPoolRatio, value);
            }

            public double QuantityOnHand => ItemID.TotalQuantityOnHand * ItemPoolRatio;

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

            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public ItemPool.FieldsClass ItemPoolID => new ItemPool.FieldsClass(GetNestedName("ItemPoolID"));
                public Items.FieldsClass ItemID => new Items.FieldsClass(GetNestedName("ItemID"));
                public OperandProperty ItemPoolRatio => new OperandProperty(GetNestedName("ItemPoolRatio"));
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
