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
            public XPCollection<Receiving> ReceivingLoadCondition => GetCollection<Receiving>("ReceivingLoadCondition");

            [Association("ReceivingPhysicalCondition", typeof(Receiving))]
            [Aggregated()]
            public XPCollection<Receiving> ReceivingPhysicalCondition => GetCollection<Receiving>("ReceivingPhysicalCondition");

            [Association("ShipingLoadCondition", typeof(Shipping))]
            [Aggregated()]
            public XPCollection<Shipping> ShipingLoadCondition => GetCollection<Shipping>("ShipingLoadCondition");

            [Association("ShipingPhysicalCondition", typeof(Shipping))]
            [Aggregated()]
            public XPCollection<Shipping> ShipingPhysicalCondition => GetCollection<Shipping>("ShipingPhysicalCondition");

            // Fields...
            private string _shipmentCondition;
            public string ShipmentCondition
            {
                get => _shipmentCondition;
                set => SetPropertyValue("ShipmentCondition", ref _shipmentCondition, value);
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
                public OperandProperty ShipmentCondition => new OperandProperty(GetNestedName("ShipmentCondition"));
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
