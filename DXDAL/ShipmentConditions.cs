using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class ShipmentConditions : AuditableBase
        {
            [Association("ReceivingLoadCondition", typeof(Receiving))]
            [Aggregated()]
            public XPCollection<Receiving> ReceivingLoadCondition
            {
                get
                {
                    return GetCollection<Receiving>("ReceivingLoadCondition");
                }
            }

            [Association("ReceivingPhysicalCondition", typeof(Receiving))]
            [Aggregated()]
            public XPCollection<Receiving> ReceivingPhysicalCondition
            {
                get
                {
                    return GetCollection<Receiving>("ReceivingPhysicalCondition");
                }
            }

            [Association("ShipingLoadCondition", typeof(Shipping))]
            [Aggregated()]
            public XPCollection<Shipping> ShipingLoadCondition
            {
                get
                {
                    return GetCollection<Shipping>("ShipingLoadCondition");
                }
            }

            [Association("ShipingPhysicalCondition", typeof(Shipping))]
            [Aggregated()]
            public XPCollection<Shipping> ShipingPhysicalCondition
            {
                get
                {
                    return GetCollection<Shipping>("ShipingPhysicalCondition");
                }
            }

            // Fields...
            private string _shipmentCondition;
            public string ShipmentCondition
            {
                get
                {
                    return _shipmentCondition;
                }
                set
                {
                    SetPropertyValue<string>("ShipmentCondition", ref _shipmentCondition, value);
                }
            }


            public ShipmentConditions() : base()
            {
            }

            public ShipmentConditions(Session session) : base(session)
            {
            }

            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }

            public class FieldClass : PersistentBase.FieldsClass
            {
                public FieldClass() : base()
                {
                }
                public FieldClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ShipmentCondition
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShipmentCondition"));
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
