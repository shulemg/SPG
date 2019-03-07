using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class Employees : AuditableBase
        {
            public string FullName => string.Format("{0} {1}", FirstName, LastName);

            [Association("Employee-Unloaded", typeof(Receiving))]
            [Aggregated()]
            public XPCollection<Receiving> Unloaded => GetCollection<Receiving>("Unloaded");

            [Association("Employee-CheckedReceiving", typeof(Receiving))]
            [Aggregated()]
            public XPCollection<Receiving> CheckedReceiving => GetCollection<Receiving>("CheckedReceiving");

            [Association("Employee-Loaded", typeof(Shipping))]
            [Aggregated()]
            public XPCollection<Shipping> Loaded => GetCollection<Shipping>("Loaded");

            [Association("Employee-CheckedShipping", typeof(Shipping))]
            [Aggregated()]
            public XPCollection<Shipping> CheckedShipping => GetCollection<Shipping>("CheckedShipping");

            [Association("Employee-UnloadedTransfer", typeof(LocationTransfers))]
            [Aggregated()]
            public XPCollection<LocationTransfers> UnloadedTransfer => GetCollection<LocationTransfers>("UnloadedTransfer");

            [Association("Employee-CheckedTransfer", typeof(LocationTransfers))]
            [Aggregated()]
            public XPCollection<LocationTransfers> CheckedTransfer => GetCollection<LocationTransfers>("CheckedTransfer");

            [Association("Employee-LoadedTransfer", typeof(LocationTransfers))]
            [Aggregated()]
            public XPCollection<LocationTransfers> LoadedTransfer => GetCollection<LocationTransfers>("LoadedTransfer");
            // Fields...
            private string _lastName;
            private string _firstName;

            [Size(50)]
            public string FirstName
            {
                get => _firstName;
                set => SetPropertyValue("FirstName", ref _firstName, value);
            }

            [Size(50)]
            public string LastName
            {
                get => _lastName;
                set => SetPropertyValue("LastName", ref _lastName, value);
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

            public class FieldClass : PersistentBase.FieldsClass
            {
                public FieldClass() : base()
                {
                }
                public FieldClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty FirstName => new OperandProperty(GetNestedName("FirstName"));
                public OperandProperty LastName => new OperandProperty(GetNestedName("LastName"));
                public OperandProperty FullName => new OperandProperty(GetNestedName("FullName"));
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
