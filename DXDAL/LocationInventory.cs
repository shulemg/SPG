using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class LocationInventory : AuditableBase
        {
            private Locations fLocation;
            [Association("Location-Inventory")]
            public Locations Location
            {
                get => fLocation;
                set => SetPropertyValue("Location", ref fLocation, value);
            }

            private Items fItem;
            [Association("LocationInventory-Item")]
            public Items LocationInventoryItem
            {
                get => fItem;
                set => SetPropertyValue("LocationInventoryItem", ref fItem, value);
            }

            private float fQuantityOnHand;
            public float QuantityOnHand
            {
                get => fQuantityOnHand;
                set => SetPropertyValue("QuantityOnHand", ref fQuantityOnHand, value);
            }

            public LocationInventory() : base()
            {
            }

            public LocationInventory(Session session) : base(session)
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
                public Locations.FieldsClass Location => new Locations.FieldsClass(GetNestedName("Location"));
                public Items.FieldsClass LocationInventoryItem => new Items.FieldsClass(GetNestedName("LocationInventoryItem"));
                public OperandProperty QuantityOnHand => new OperandProperty(GetNestedName("QuantityOnHand"));
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
