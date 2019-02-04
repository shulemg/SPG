using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class Employees : AuditableBase
        {
            public string FullName
            {
                get
                {
                    return string.Format("{0} {1}", FirstName, LastName);
                }
            }

            [Association("Employee-Unloaded", typeof(Receiving))]
            [Aggregated()]
            public XPCollection<Receiving> Unloaded
            {
                get
                {
                    return GetCollection<Receiving>("Unloaded");
                }
            }

            [Association("Employee-CheckedReceiving", typeof(Receiving))]
            [Aggregated()]
            public XPCollection<Receiving> CheckedReceiving
            {
                get
                {
                    return GetCollection<Receiving>("CheckedReceiving");
                }
            }

            [Association("Employee-Loaded", typeof(Shipping))]
            [Aggregated()]
            public XPCollection<Shipping> Loaded
            {
                get
                {
                    return GetCollection<Shipping>("Loaded");
                }
            }

            [Association("Employee-CheckedShipping", typeof(Shipping))]
            [Aggregated()]
            public XPCollection<Shipping> CheckedShipping
            {
                get
                {
                    return GetCollection<Shipping>("CheckedShipping");
                }
            }

            [Association("Employee-UnloadedTransfer", typeof(LocationTransfers))]
            [Aggregated()]
            public XPCollection<LocationTransfers> UnloadedTransfer
            {
                get
                {
                    return GetCollection<LocationTransfers>("UnloadedTransfer");
                }
            }

            [Association("Employee-CheckedTransfer", typeof(LocationTransfers))]
            [Aggregated()]
            public XPCollection<LocationTransfers> CheckedTransfer
            {
                get
                {
                    return GetCollection<LocationTransfers>("CheckedTransfer");
                }
            }

            [Association("Employee-LoadedTransfer", typeof(LocationTransfers))]
            [Aggregated()]
            public XPCollection<LocationTransfers> LoadedTransfer
            {
                get
                {
                    return GetCollection<LocationTransfers>("LoadedTransfer");
                }
            }
            // Fields...
            private string _lastName;
            private string _firstName;

            [Size(50)]
            public string FirstName
            {
                get
                {
                    return _firstName;
                }
                set
                {
                    SetPropertyValue<string>("FirstName", ref _firstName, value);
                }
            }

            [Size(50)]
            public string LastName
            {
                get
                {
                    return _lastName;
                }
                set
                {
                    SetPropertyValue<string>("LastName", ref _lastName, value);
                }
            }

            public Employees() : base()
            {
            }

            public Employees(Session session) : base(session)
            {
            }

            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }

            public new class FieldClass : PersistentBase.FieldsClass
            {
                public FieldClass() : base()
                {
                }
                public FieldClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty FirstName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("FirstName"));
                    }
                }
                public OperandProperty LastName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LastName"));
                    }
                }
                public OperandProperty FullName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("FullName"));
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
