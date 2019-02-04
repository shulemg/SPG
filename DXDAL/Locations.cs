using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class Locations : AuditableBase
        {
            private string fLocationCode;
            [Size(25)]
            public string LocationCode
            {
                get
                {
                    return fLocationCode;
                }
                set
                {
                    SetPropertyValue<string>("LocationCode", ref fLocationCode, value);
                }
            }

            private string fLocationName;
            [Size(50)]
            public string LocationName
            {
                get
                {
                    return fLocationName;
                }
                set
                {
                    SetPropertyValue<string>("LocationName", ref fLocationName, value);
                }
            }

            private string fLocationAddress;
            [Size(150)]
            public string LocationAddress
            {
                get
                {
                    return fLocationAddress;
                }
                set
                {
                    SetPropertyValue<string>("LocationAddress", ref fLocationAddress, value);
                }
            }

            private string fLocationCity;
            [Size(150)]
            public string LocationCity
            {
                get
                {
                    return fLocationCity;
                }
                set
                {
                    SetPropertyValue<string>("LocationCity", ref fLocationCity, value);
                }
            }

            private string fLocationState;
            [Size(50)]
            public string LocationState
            {
                get
                {
                    return fLocationState;
                }
                set
                {
                    SetPropertyValue<string>("LocationState", ref fLocationState, value);
                }
            }

            private string fLocationZipCode;
            [Size(50)]
            public string LocationZipCode
            {
                get
                {
                    return fLocationZipCode;
                }
                set
                {
                    SetPropertyValue<string>("LocationZipCode", ref fLocationZipCode, value);
                }
            }

            private string fLocationPhone;
            [Size(50)]
            public string LocationPhone
            {
                get
                {
                    return fLocationPhone;
                }
                set
                {
                    SetPropertyValue<string>("LocationPhone", ref fLocationPhone, value);
                }
            }

            private string fLocationFax;
            [Size(50)]
            public string LocationFax
            {
                get
                {
                    return fLocationFax;
                }
                set
                {
                    SetPropertyValue<string>("LocationFax", ref fLocationFax, value);
                }
            }

            private bool fCanReceive;
            public bool CanReceive
            {
                get
                {
                    return fCanReceive;
                }
                set
                {
                    SetPropertyValue<bool>("CanReceive", ref fCanReceive, value);
                }
            }

            private bool fCanProduce;
            public bool CanProduce
            {
                get
                {
                    return fCanProduce;
                }
                set
                {
                    SetPropertyValue<bool>("CanProduce", ref fCanProduce, value);
                }
            }

            private bool fCanShip;
            public bool CanShip
            {
                get
                {
                    return fCanShip;
                }
                set
                {
                    SetPropertyValue<bool>("CanShip", ref fCanShip, value);
                }
            }

            private bool fCanWarehouse;
            public bool CanWarehouse
            {
                get
                {
                    return fCanWarehouse;
                }
                set
                {
                    SetPropertyValue<bool>("CanWarehouse", ref fCanWarehouse, value);
                }
            }

            private bool fInventoryAvailable;
            public bool InventoryAvailable
            {
                get
                {
                    return fInventoryAvailable;
                }
                set
                {
                    SetPropertyValue<bool>("InventoryAvailable", ref fInventoryAvailable, value);
                }
            }

            [Association("Location-Inventory", typeof(LocationInventory))]
            [Aggregated()]
            public XPCollection<LocationInventory> LocationsInventory
            {
                get
                {
                    return GetCollection<LocationInventory>("LocationsInventory");
                }
            }

            [Association("Location-InventoryByLot", typeof(LocationInventoryByLot))]
            [Aggregated()]
            public XPCollection<LocationInventoryByLot> LocationsInventoryByLot
            {
                get
                {
                    return GetCollection<LocationInventoryByLot>("LocationsInventoryByLot");
                }
            }

            [Association("Location-TransfersFrom", typeof(LocationTransfers))]
            [Aggregated()]
            public XPCollection<LocationTransfers> LocationTransfersFrom
            {
                get
                {
                    return GetCollection<LocationTransfers>("LocationTransfersFrom");
                }
            }

            [Association("Location-TransfersTo", typeof(LocationTransfers))]
            [Aggregated()]
            public XPCollection<LocationTransfers> LocationTransfersTo
            {
                get
                {
                    return GetCollection<LocationTransfers>("LocationTransfersTo");
                }
            }

            [Association("Location-Receivings", typeof(Receiving))]
            [Aggregated()]
            public XPCollection<Receiving> LocationReceivings
            {
                get
                {
                    return GetCollection<Receiving>("LocationReceivings");
                }
            }

            [Association("Location-Shippings", typeof(Shipping))]
            [Aggregated()]
            public XPCollection<Shipping> LocationShippings
            {
                get
                {
                    return GetCollection<Shipping>("LocationShippings");
                }
            }

            [Association("Production-Location", typeof(Inventory))]
            [Aggregated()]
            public XPCollection<Inventory> LocationProduction
            {
                get
                {
                    return GetCollection<Inventory>("LocationProduction");
                }
            }

            public Locations() : base()
            {
            }

            public Locations(Session session) : base(session)
            {
            }

            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }

            public new class FieldsClass : XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty Oid
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Oid"));
                    }
                }
                public OperandProperty LocationCode
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LocationCode"));
                    }
                }
                public OperandProperty LocationName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LocationName"));
                    }
                }
                public OperandProperty LocationAddress
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LocationAddress"));
                    }
                }
                public OperandProperty LocationCity
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LocationCity"));
                    }
                }
                public OperandProperty LocationState
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LocationState"));
                    }
                }
                public OperandProperty LocationZipCode
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LocationZipCode"));
                    }
                }
                public OperandProperty LocationPhone
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LocationPhone"));
                    }
                }
                public OperandProperty LocationFax
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LocationFax"));
                    }
                }
                public OperandProperty CanReceive
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CanReceive"));
                    }
                }
                public OperandProperty CanProduce
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CanProduce"));
                    }
                }
                public OperandProperty CanShip
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CanShip"));
                    }
                }
                public OperandProperty CanWarehouse
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CanWarehouse"));
                    }
                }
                public OperandProperty InventoryAvailable
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("InventoryAvailable"));
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
