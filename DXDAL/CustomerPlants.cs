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
                get
                {
                    return fCustomer;
                }
                set
                {
                    SetPropertyValue("Customer", ref fCustomer, value);
                }
            }

            private string fPlantName;
            [Size(150)]
            public string PlantName
            {
                get
                {
                    return fPlantName;
                }
                set
                {
                    SetPropertyValue("PlantName", ref fPlantName, value);
                }
            }

            private string fPlantCode;
            [Size(10)]
            public string PlantCode
            {
                get
                {
                    return fPlantCode;
                }
                set
                {
                    SetPropertyValue("PlantCode", ref fPlantCode, value);
                }
            }

            private Locations fSPGLocation;
            public Locations SPGLocation
            {
                get
                {
                    return fSPGLocation;
                }
                set
                {
                    SetPropertyValue("SPGLocation", ref fSPGLocation, value);
                }
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
                public Customers.FieldsClass Customer
                {
                    get
                    {
                        return new Customers.FieldsClass(GetNestedName("Customer"));
                    }
                }
                public OperandProperty PlantName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PlantName"));
                    }
                }
                public OperandProperty PlantCode
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PlantCode"));
                    }
                }
                public Locations.FieldsClass SPGLocation
                {
                    get
                    {
                        return new Locations.FieldsClass(GetNestedName("SPGLocation"));
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
