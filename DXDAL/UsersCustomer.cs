using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        public class UsersCustomer : XPObject
        {
            private Users _user;
            [Association("UsersCustomer-User")]
            public Users User
            {
                get => _user;
                set => SetPropertyValue("User", ref _user, value);
            }

            private Customers _customer;
            [Association("UsersCustomer-Customer")]
            public Customers Customer
            {
                get => _customer;
                set => SetPropertyValue("Customer", ref _customer, value);
            }

            public UsersCustomer() : base()
            {
            }

            public UsersCustomer(Session session) : base(session)
            {
            }

            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }
            public new class FieldsClass : XPObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public Users.FieldsClass User => new Users.FieldsClass(GetNestedName("User"));
                public Customers.FieldsClass Customer => new Customers.FieldsClass(GetNestedName("Customer"));
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
