using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblUsers")]
        public class Users : XPLiteObject
        {
            [Association("UsersCustomer-User", typeof(UsersCustomer))]
            [Aggregated()]
            public XPCollection<UsersCustomer> AssignedCustomer => GetCollection<UsersCustomer>("AssignedCustomer");

            private string fstrUserName;
            [Key()]
            [Size(50)]
            public string strUserName
            {
                get => fstrUserName;
                set => SetPropertyValue("strUserName", ref fstrUserName, value);
            }
            private string fstrPassword;
            [Size(50)]
            public string strPassword
            {
                get => fstrPassword;
                set => SetPropertyValue("strPassword", ref fstrPassword, value);
            }
            private string fstrSecurityLevel;
            [Size(50)]
            public string strSecurityLevel
            {
                get => fstrSecurityLevel;
                set => SetPropertyValue("strSecurityLevel", ref fstrSecurityLevel, value);
            }
            private string fLPNPrinterName;
            public string LPNPrinterName
            {
                get => fLPNPrinterName;
                set => SetPropertyValue("LPNPrinterName", ref fLPNPrinterName, value);
            }

            private Locations fDefaultLocation;
            public Locations DefaultLocation
            {
                get => fDefaultLocation;
                set => SetPropertyValue("DefaultLocation", ref fDefaultLocation, value);
            }
            public Users(Session session) : base(session)
            {
            }
            public Users() : base(Session.DefaultSession)
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
                public OperandProperty strUserName => new OperandProperty(GetNestedName("strUserName"));
                public OperandProperty strPassword => new OperandProperty(GetNestedName("strPassword"));
                public OperandProperty strSecurityLevel => new OperandProperty(GetNestedName("strSecurityLevel"));
                public OperandProperty LPNPrinterName => new OperandProperty(GetNestedName("LPNPrinterName"));
                public Locations.FieldsClass DefaultLocation => new Locations.FieldsClass(GetNestedName("DefaultLocation"));
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
