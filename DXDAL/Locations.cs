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
                get => fLocationCode;
                set => SetPropertyValue("LocationCode", ref fLocationCode, value);
            }

            private string fLocationName;
            [Size(50)]
            public string LocationName
            {
                get => fLocationName;
                set => SetPropertyValue("LocationName", ref fLocationName, value);
            }

            private string fLocationAddress;
            [Size(150)]
            public string LocationAddress
            {
                get => fLocationAddress;
                set => SetPropertyValue("LocationAddress", ref fLocationAddress, value);
            }

            private string fLocationCity;
            [Size(150)]
            public string LocationCity
            {
                get => fLocationCity;
                set => SetPropertyValue("LocationCity", ref fLocationCity, value);
            }

            private string fLocationState;
            [Size(50)]
            public string LocationState
            {
                get => fLocationState;
                set => SetPropertyValue("LocationState", ref fLocationState, value);
            }

            private string fLocationZipCode;
            [Size(50)]
            public string LocationZipCode
            {
                get => fLocationZipCode;
                set => SetPropertyValue("LocationZipCode", ref fLocationZipCode, value);
            }

            private string fLocationPhone;
            [Size(50)]
            public string LocationPhone
            {
                get => fLocationPhone;
                set => SetPropertyValue("LocationPhone", ref fLocationPhone, value);
            }

            private string fLocationFax;
            [Size(50)]
            public string LocationFax
            {
                get => fLocationFax;
                set => SetPropertyValue("LocationFax", ref fLocationFax, value);
            }

            private bool fCanReceive;
            public bool CanReceive
            {
                get => fCanReceive;
                set => SetPropertyValue("CanReceive", ref fCanReceive, value);
            }

            private bool fCanProduce;
            public bool CanProduce
            {
                get => fCanProduce;
                set => SetPropertyValue("CanProduce", ref fCanProduce, value);
            }

            private bool fCanShip;
            public bool CanShip
            {
                get => fCanShip;
                set => SetPropertyValue("CanShip", ref fCanShip, value);
            }

            private bool fCanWarehouse;
            public bool CanWarehouse
            {
                get => fCanWarehouse;
                set => SetPropertyValue("CanWarehouse", ref fCanWarehouse, value);
            }

            private bool fInventoryAvailable;
            public bool InventoryAvailable
            {
                get => fInventoryAvailable;
                set => SetPropertyValue("InventoryAvailable", ref fInventoryAvailable, value);
            }

            [Association("Location-Inventory", typeof(LocationInventory))]
            [Aggregated()]
            public XPCollection<LocationInventory> LocationsInventory => GetCollection<LocationInventory>("LocationsInventory");

            [Association("Location-InventoryByLot", typeof(LocationInventoryByLot))]
            [Aggregated()]
            public XPCollection<LocationInventoryByLot> LocationsInventoryByLot => GetCollection<LocationInventoryByLot>("LocationsInventoryByLot");

            [Association("Location-TransfersFrom", typeof(LocationTransfers))]
            [Aggregated()]
            public XPCollection<LocationTransfers> LocationTransfersFrom => GetCollection<LocationTransfers>("LocationTransfersFrom");

            [Association("Location-TransfersTo", typeof(LocationTransfers))]
            [Aggregated()]
            public XPCollection<LocationTransfers> LocationTransfersTo => GetCollection<LocationTransfers>("LocationTransfersTo");

            [Association("Location-Receivings", typeof(Receiving))]
            [Aggregated()]
            public XPCollection<Receiving> LocationReceivings => GetCollection<Receiving>("LocationReceivings");

            [Association("Location-Shippings", typeof(Shipping))]
            [Aggregated()]
            public XPCollection<Shipping> LocationShippings => GetCollection<Shipping>("LocationShippings");

            [Association("Production-Location", typeof(Inventory))]
            [Aggregated()]
            public XPCollection<Inventory> LocationProduction => GetCollection<Inventory>("LocationProduction");

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

            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty Oid => new OperandProperty(GetNestedName("Oid"));
                public OperandProperty LocationCode => new OperandProperty(GetNestedName("LocationCode"));
                public OperandProperty LocationName => new OperandProperty(GetNestedName("LocationName"));
                public OperandProperty LocationAddress => new OperandProperty(GetNestedName("LocationAddress"));
                public OperandProperty LocationCity => new OperandProperty(GetNestedName("LocationCity"));
                public OperandProperty LocationState => new OperandProperty(GetNestedName("LocationState"));
                public OperandProperty LocationZipCode => new OperandProperty(GetNestedName("LocationZipCode"));
                public OperandProperty LocationPhone => new OperandProperty(GetNestedName("LocationPhone"));
                public OperandProperty LocationFax => new OperandProperty(GetNestedName("LocationFax"));
                public OperandProperty CanReceive => new OperandProperty(GetNestedName("CanReceive"));
                public OperandProperty CanProduce => new OperandProperty(GetNestedName("CanProduce"));
                public OperandProperty CanShip => new OperandProperty(GetNestedName("CanShip"));
                public OperandProperty CanWarehouse => new OperandProperty(GetNestedName("CanWarehouse"));
                public OperandProperty InventoryAvailable => new OperandProperty(GetNestedName("InventoryAvailable"));
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
