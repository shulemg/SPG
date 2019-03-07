using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        public class CustomerPlants : AuditableBase
        {
            private Customers fCustomer;
            [Association("Customer-Plants")]
            public Customers Customer
            {
                get => fCustomer;
                set => SetPropertyValue("Customer", ref fCustomer, value);
            }

            private string fPlantName;
            [Size(150)]
            public string PlantName
            {
                get => fPlantName;
                set => SetPropertyValue("PlantName", ref fPlantName, value);
            }

            private string fPlantCode;
            [Size(10)]
            public string PlantCode
            {
                get => fPlantCode;
                set => SetPropertyValue("PlantCode", ref fPlantCode, value);
            }

            private Locations fSPGLocation;
            public Locations SPGLocation
            {
                get => fSPGLocation;
                set => SetPropertyValue("SPGLocation", ref fSPGLocation, value);
            }

            public CustomerPlants() : base()
            {
            }

            public CustomerPlants(Session session) : base(session)
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
                public Customers.FieldsClass Customer => new Customers.FieldsClass(GetNestedName("Customer"));
                public OperandProperty PlantName => new OperandProperty(GetNestedName("PlantName"));
                public OperandProperty PlantCode => new OperandProperty(GetNestedName("PlantCode"));
                public Locations.FieldsClass SPGLocation => new Locations.FieldsClass(GetNestedName("SPGLocation"));
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
