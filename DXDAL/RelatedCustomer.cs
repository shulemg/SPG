using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        public class RelatedCustomer : XPObject
        {
            public RelatedCustomer(Session session) : base(session)
            {
            }


            private Customers m_MainCustomer;

            public RelatedCustomer()
            {
            }

            [Association("Customer-RelatedCustomers")]
            public Customers MainCustomer
            {
                get
                {
                    return m_MainCustomer;
                }
                set
                {
                    SetPropertyValue<Customers>("MainCustomer", ref m_MainCustomer, value);
                }
            }

            private Customers m_RelatedCustomer;
            public Customers relatedCustomer
            {
                get
                {
                    return m_RelatedCustomer;
                }
                set
                {
                    SetPropertyValue<Customers>("relatedCustomer", ref m_RelatedCustomer, value);
                }
            }

            private bool m_Bidirectional;
            public bool Bidirectional
            {
                get
                {
                    return m_Bidirectional;
                }
                set
                {
                    SetPropertyValue<bool>("Bidirectional", ref m_Bidirectional, value);
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
            // Created/Updated: Joel-PC\Joel on JOEL-PC at 11/08/10 6:50 PM
            public new class FieldsClass : DevExpress.Xpo.XPObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public Customers.FieldsClass MainCustomer
                {
                    get
                    {
                        return new Customers.FieldsClass(GetNestedName("MainCustomer"));
                    }
                }
                public Customers.FieldsClass relatedCustomer
                {
                    get
                    {
                        return new Customers.FieldsClass(GetNestedName("relatedCustomer"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty Bidirectional
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("Bidirectional"));
                    }
                }
            }
        }
    }
}
