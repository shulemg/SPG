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
            public XPCollection<UsersCustomer> AssignedCustomer
            {
                get
                {
                    return GetCollection<UsersCustomer>("AssignedCustomer");
                }
            }

            private string fstrUserName;
            [Key()]
            [Size(50)]
            public string strUserName
            {
                get
                {
                    return fstrUserName;
                }
                set
                {
                    SetPropertyValue<string>("strUserName", ref fstrUserName, value);
                }
            }
            private string fstrPassword;
            [Size(50)]
            public string strPassword
            {
                get
                {
                    return fstrPassword;
                }
                set
                {
                    SetPropertyValue<string>("strPassword", ref fstrPassword, value);
                }
            }
            private string fstrSecurityLevel;
            [Size(50)]
            public string strSecurityLevel
            {
                get
                {
                    return fstrSecurityLevel;
                }
                set
                {
                    SetPropertyValue<string>("strSecurityLevel", ref fstrSecurityLevel, value);
                }
            }
            private string fLPNPrinterName;
            public string LPNPrinterName
            {
                get
                {
                    return fLPNPrinterName;
                }
                set
                {
                    SetPropertyValue<string>("LPNPrinterName", ref fLPNPrinterName, value);
                }
            }

            private Locations fDefaultLocation;
            public Locations DefaultLocation
            {
                get
                {
                    return fDefaultLocation;
                }
                set
                {
                    SetPropertyValue<Locations>("DefaultLocation", ref fDefaultLocation, value);
                }
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
            public new class FieldsClass : DevExpress.Xpo.PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty strUserName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strUserName"));
                    }
                }
                public OperandProperty strPassword
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strPassword"));
                    }
                }
                public OperandProperty strSecurityLevel
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strSecurityLevel"));
                    }
                }
                public OperandProperty LPNPrinterName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LPNPrinterName"));
                    }
                }
                public Locations.FieldsClass DefaultLocation
                {
                    get
                    {
                        return new Locations.FieldsClass(GetNestedName("DefaultLocation"));
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
