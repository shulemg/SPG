using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class Vendor : XPObject
        {
            public Vendor(Session session) : base(session)
            {
            }


            private string m_VendorName;
            [Size(150)]
            public string VendorName
            {
                get => m_VendorName;
                set => SetPropertyValue("VendorName", ref m_VendorName, value);
            }



            [Association("Receiving-Vendor", typeof(Receiving))]
            [Aggregated()]
            public XPCollection<Receiving> Receivings => GetCollection<Receiving>("Receivings");










            public new class FieldsClass : XPObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty VendorName => new OperandProperty(GetNestedName("VendorName"));
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
