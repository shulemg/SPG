using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class LocationInventoryByLot : AuditableBase
        {
            private Locations fLocation;
            [Association("Location-InventoryByLot")]
            public Locations Location
            {
                get => fLocation;
                set => SetPropertyValue("Location", ref fLocation, value);
            }

            private Items fItem;
            [Association("LocationInventoryByLot-Item")]
            public Items LocationInventoryItem
            {
                get => fItem;
                set => SetPropertyValue("LocationInventoryItem", ref fItem, value);
            }

            private string fLot;
            public string LocationInventoryLot
            {
                get => fLot;
                set => SetPropertyValue("LocationInventoryLot", ref fLot, value);
            }

            private int? fLPNNumber;
            public int? LPNNumber
            {
                get => fLPNNumber;
                set => SetPropertyValue("LPNNumber", ref fLPNNumber, value);
            }

            private float fQuantityOnHand;
            public float QuantityOnHand
            {
                get => fQuantityOnHand;
                set => SetPropertyValue("QuantityOnHand", ref fQuantityOnHand, value);
            }
            private DateTime? fExpirationDate;
            public DateTime? ExpirationDate
            {
                get => fExpirationDate;
                set
                {
                    if (value < DateTime.Parse("1990-01-01"))
                        value = default(DateTime?);
                    SetPropertyValue("ExpirationDate", ref fExpirationDate, value);
                }
            }

            public LocationInventoryByLot() : base()
            {
            }

            public LocationInventoryByLot(Session session) : base(session)
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
                public OperandProperty LocationInventoryLot => new OperandProperty(GetNestedName("LocationInventoryLot"));
                public OperandProperty LPNNumber => new OperandProperty(GetNestedName("LPNNumber"));
                public OperandProperty QuantityOnHand => new OperandProperty(GetNestedName("QuantityOnHand"));
                public OperandProperty ExpirationDate => new OperandProperty(GetNestedName("ExpirationDate"));
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
