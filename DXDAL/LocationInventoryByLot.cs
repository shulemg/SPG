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
                get
                {
                    return fLocation;
                }
                set
                {
                    SetPropertyValue<Locations>("Location", ref fLocation, value);
                }
            }

            private Items fItem;
            [Association("LocationInventoryByLot-Item")]
            public Items LocationInventoryItem
            {
                get
                {
                    return fItem;
                }
                set
                {
                    SetPropertyValue<Items>("LocationInventoryItem", ref fItem, value);
                }
            }

            private string fLot;
            public string LocationInventoryLot
            {
                get
                {
                    return fLot;
                }
                set
                {
                    SetPropertyValue<string>("LocationInventoryLot", ref fLot, value);
                }
            }

            private int? fLPNNumber;
            public int? LPNNumber
            {
                get
                {
                    return fLPNNumber;
                }
                set
                {
                    SetPropertyValue<int?>("LPNNumber", ref fLPNNumber, value);
                }
            }

            private float fQuantityOnHand;
            public float QuantityOnHand
            {
                get
                {
                    return fQuantityOnHand;
                }
                set
                {
                    SetPropertyValue<float>("QuantityOnHand", ref fQuantityOnHand, value);
                }
            }
            private DateTime? fExpirationDate;
            public DateTime? ExpirationDate
            {
                get
                {
                    return fExpirationDate;
                }
                set
                {
                    if (value < DateTime.Parse("1990-01-01"))
                        value = default(DateTime?);
                    SetPropertyValue<DateTime?>("ExpirationDate", ref fExpirationDate, value);
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

            public new class FieldsClass : DevExpress.Xpo.PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public Locations.FieldsClass Location
                {
                    get
                    {
                        return new Locations.FieldsClass(GetNestedName("Location"));
                    }
                }
                public Items.FieldsClass LocationInventoryItem
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("LocationInventoryItem"));
                    }
                }
                public OperandProperty LocationInventoryLot
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LocationInventoryLot"));
                    }
                }
                public OperandProperty LPNNumber
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LPNNumber"));
                    }
                }
                public OperandProperty QuantityOnHand
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("QuantityOnHand"));
                    }
                }
                public OperandProperty ExpirationDate
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ExpirationDate"));
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
