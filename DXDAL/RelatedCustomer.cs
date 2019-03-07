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
                get => m_MainCustomer;
                set => SetPropertyValue("MainCustomer", ref m_MainCustomer, value);
            }

            private Customers m_RelatedCustomer;
            public Customers relatedCustomer
            {
                get => m_RelatedCustomer;
                set => SetPropertyValue("relatedCustomer", ref m_RelatedCustomer, value);
            }

            private bool m_Bidirectional;
            public bool Bidirectional
            {
                get => m_Bidirectional;
                set => SetPropertyValue("Bidirectional", ref m_Bidirectional, value);
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
            public new class FieldsClass : XPObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public Customers.FieldsClass MainCustomer => new Customers.FieldsClass(GetNestedName("MainCustomer"));
                public Customers.FieldsClass relatedCustomer => new Customers.FieldsClass(GetNestedName("relatedCustomer"));
                public DevExpress.Data.Filtering.OperandProperty Bidirectional => new DevExpress.Data.Filtering.OperandProperty(GetNestedName("Bidirectional"));
            }
        }
    }
}
