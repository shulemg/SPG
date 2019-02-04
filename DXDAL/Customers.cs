using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblCustomers")]
        public class Customers : XPLiteObject
        {
            [Association("UsersCustomer-Customer", typeof(UsersCustomer))]
            [Aggregated()]
            public XPCollection<UsersCustomer> AssignedUser
            {
                get
                {
                    return GetCollection<UsersCustomer>("AssignedUser");
                }
            }

            [Association("Customer-RelatedCustomers", typeof(RelatedCustomer))]
            [Aggregated()]
            public XPCollection<RelatedCustomer> RelatedCustomers
            {
                get
                {
                    return GetCollection<RelatedCustomer>("RelatedCustomers");
                }
            }

            [Association("Customer-Projects", typeof(Project))]
            [Aggregated()]
            public XPCollection<Project> Projects
            {
                get
                {
                    return GetCollection<Project>("Projects");
                }
            }

            public XPCollection<Items> Items
            {
                get
                {
                    return GetCollection<Items>("Items");
                }
            }

            [Association("Customer-Shifts", typeof(CustomerShifts))]
            [Aggregated()]
            public XPCollection<CustomerShifts> CustomerShifts
            {
                get
                {
                    return GetCollection<CustomerShifts>("CustomerShifts");
                }
            }

            [Association("Customer-Plants", typeof(CustomerPlants))]
            [Aggregated()]
            public XPCollection<CustomerPlants> CustomerPlants
            {
                get
                {
                    return GetCollection<CustomerPlants>("CustomerPlants");
                }
            }

            private string _plantCode;
            private int _nextLPNNumber;
            private int? _lastLPNNumber;
            private int? _firstLPNNumber;
            private string _lPNPrefix;
            private string _expirationDateFormat;
            private LotCodeFormats _defaultLotCodeFormat;

            private int fCustomerID;
            [Key()]
            public int CustomerID
            {
                get
                {
                    return fCustomerID;
                }
                set
                {
                    SetPropertyValue<int>("CustomerID", ref fCustomerID, value);
                }
            }
            private string m_CustomerName;
            [Size(50)]
            public string CustomerName
            {
                get
                {
                    return m_CustomerName;
                }
                set
                {
                    SetPropertyValue<string>("CustomerName", ref m_CustomerName, value);
                }
            }
            private string m_CustomerContact;
            [Size(50)]
            public string CustomerContact
            {
                get
                {
                    return m_CustomerContact;
                }
                set
                {
                    SetPropertyValue<string>("CustomerContact", ref m_CustomerContact, value);
                }
            }
            private string fCustomerPhone;
            [Size(50)]
            public string CustomerPhone
            {
                get
                {
                    return fCustomerPhone;
                }
                set
                {
                    SetPropertyValue<string>("CustomerPhone", ref fCustomerPhone, value);
                }
            }
            private string fCustomerEmail;
            [Size(50)]
            public string CustomerEmail
            {
                get
                {
                    return fCustomerEmail;
                }
                set
                {
                    SetPropertyValue<string>("CustomerEmail", ref fCustomerEmail, value);
                }
            }
            private string fCustomerFax;
            [Size(50)]
            public string CustomerFax
            {
                get
                {
                    return fCustomerFax;
                }
                set
                {
                    SetPropertyValue<string>("CustomerFax", ref fCustomerFax, value);
                }
            }
            private string fCustomerNote;
            [Size(250)]
            public string CustomerNote
            {
                get
                {
                    return fCustomerNote;
                }
                set
                {
                    SetPropertyValue<string>("CustomerNote", ref fCustomerNote, value);
                }
            }
            private string fstrEnteredBy;
            [Size(50)]
            public string strEnteredBy
            {
                get
                {
                    return fstrEnteredBy;
                }
                set
                {
                    SetPropertyValue<string>("strEnteredBy", ref fstrEnteredBy, value);
                }
            }
            private DateTime fdtmEnteredOn;
            public DateTime dtmEnteredOn
            {
                get
                {
                    return fdtmEnteredOn;
                }
                set
                {
                    SetPropertyValue<DateTime>("dtmEnteredOn", ref fdtmEnteredOn, value);
                }
            }
            private string fAddress;
            [Size(150)]
            public string Address
            {
                get
                {
                    return fAddress;
                }
                set
                {
                    SetPropertyValue<string>("Address", ref fAddress, value);
                }
            }
            private string fCity;
            [Size(150)]
            public string City
            {
                get
                {
                    return fCity;
                }
                set
                {
                    SetPropertyValue<string>("City", ref fCity, value);
                }
            }
            private string fState;
            [Size(50)]
            public string State
            {
                get
                {
                    return fState;
                }
                set
                {
                    SetPropertyValue<string>("State", ref fState, value);
                }
            }
            private string fZipCode;
            [Size(50)]
            public string ZipCode
            {
                get
                {
                    return fZipCode;
                }
                set
                {
                    SetPropertyValue<string>("ZipCode", ref fZipCode, value);
                }
            }
            private bool fInactive;
            public bool Inactive
            {
                get
                {
                    return fInactive;
                }
                set
                {
                    SetPropertyValue<bool>("Inactive", ref fInactive, value);
                }
            }
            private bool fEditing;
            public bool Editing
            {
                get
                {
                    return fEditing;
                }
                set
                {
                    SetPropertyValue<bool>("Editing", ref fEditing, value);
                }
            }

            public string LPNPrefix
            {
                get
                {
                    return _lPNPrefix;
                }
                set
                {
                    SetPropertyValue<string>("LPNPrefix", ref _lPNPrefix, value);
                }
            }

            public int? FirstLPNNumber
            {
                get
                {
                    return _firstLPNNumber;
                }
                set
                {
                    SetPropertyValue<int?>("FirstLPNNumber", ref _firstLPNNumber, value);
                }
            }

            public int? LastLPNNumber
            {
                get
                {
                    return _lastLPNNumber;
                }
                set
                {
                    SetPropertyValue<int?>("LastLPNNumber", ref _lastLPNNumber, value);
                }
            }

            public int NextLPNNumber
            {
                get
                {
                    return _nextLPNNumber;
                }
                set
                {
                    SetPropertyValue<int>("NextLPNNumber", ref _nextLPNNumber, value);
                }
            }

            public string PlantCode
            {
                get
                {
                    return _plantCode;
                }
                set
                {
                    SetPropertyValue<string>("PlantCode", ref _plantCode, value);
                }
            }

            public string ExpirationDateFormat
            {
                get
                {
                    if (string.IsNullOrEmpty(_expirationDateFormat))
                        return "MM/dd/yyyy";
                    return _expirationDateFormat;
                }
                set
                {
                    SetPropertyValue<string>("ExpirationDateFormat", ref _expirationDateFormat, value);
                }
            }

            public LotCodeFormats DefaultLotCodeFormat
            {
                get
                {
                    return _defaultLotCodeFormat;
                }
                set
                {
                    SetPropertyValue("DefaultLotCodeFormat", ref _defaultLotCodeFormat, value);
                }
            }

            public Customers(Session session) : base(session)
            {
            }
            public Customers() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }
            // Created/Updated: Joel-PC\Joel on JOEL-PC at 3/8/2013 8:14 AM
            public new class FieldsClass : XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public const string AssignedUserFieldName = "AssignedUser";
                public DevExpress.Data.Filtering.OperandProperty AssignedUser
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("AssignedUser"));
                    }
                }
                public const string RelatedCustomersFieldName = "RelatedCustomers";
                public DevExpress.Data.Filtering.OperandProperty RelatedCustomers
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("RelatedCustomers"));
                    }
                }
                public OperandProperty CustomerID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CustomerID"));
                    }
                }
                public const string CustomerNameFieldName = "CustomerName";
                public DevExpress.Data.Filtering.OperandProperty CustomerName
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("CustomerName"));
                    }
                }
                public const string CustomerContactFieldName = "CustomerContact";
                public DevExpress.Data.Filtering.OperandProperty CustomerContact
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("CustomerContact"));
                    }
                }
                public const string CustomerPhoneFieldName = "CustomerPhone";
                public DevExpress.Data.Filtering.OperandProperty CustomerPhone
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("CustomerPhone"));
                    }
                }
                public const string CustomerEmailFieldName = "CustomerEmail";
                public DevExpress.Data.Filtering.OperandProperty CustomerEmail
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("CustomerEmail"));
                    }
                }
                public const string CustomerFaxFieldName = "CustomerFax";
                public DevExpress.Data.Filtering.OperandProperty CustomerFax
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("CustomerFax"));
                    }
                }
                public const string CustomerNoteFieldName = "CustomerNote";
                public DevExpress.Data.Filtering.OperandProperty CustomerNote
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("CustomerNote"));
                    }
                }
                public const string strEnteredByFieldName = "strEnteredBy";
                public DevExpress.Data.Filtering.OperandProperty strEnteredBy
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("strEnteredBy"));
                    }
                }
                public OperandProperty dtmEnteredOn
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dtmEnteredOn"));
                    }
                }
                public const string AddressFieldName = "Address";
                public DevExpress.Data.Filtering.OperandProperty Address
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("Address"));
                    }
                }
                public const string CityFieldName = "City";
                public DevExpress.Data.Filtering.OperandProperty City
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("City"));
                    }
                }
                public const string StateFieldName = "State";
                public DevExpress.Data.Filtering.OperandProperty State
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("State"));
                    }
                }
                public const string ZipCodeFieldName = "ZipCode";
                public DevExpress.Data.Filtering.OperandProperty ZipCode
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ZipCode"));
                    }
                }
                public OperandProperty Inactive
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Inactive"));
                    }
                }
                public OperandProperty Editing
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Editing"));
                    }
                }
                public const string LPNPrefixFieldName = "LPNPrefix";
                public DevExpress.Data.Filtering.OperandProperty LPNPrefix
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("LPNPrefix"));
                    }
                }
                public OperandProperty FirstLPNNumber
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("FirstLPNNumber"));
                    }
                }
                public OperandProperty LastLPNNumber
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LastLPNNumber"));
                    }
                }
                public OperandProperty NextLPNNumber
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("NextLPNNumber"));
                    }
                }
                public const string PlantCodeFieldName = "PlantCode";
                public DevExpress.Data.Filtering.OperandProperty PlantCode
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("PlantCode"));
                    }
                }
                public const string ExpirationDateFormatFieldName = "ExpirationDateFormat";
                public OperandProperty ExpirationDateFormat
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ExpirationDateFormat"));
                    }
                }
                public LotCodeFormats.FieldsClass DefaultLotCodeFormat
                {
                    get
                    {
                        return new LotCodeFormats.FieldsClass(GetNestedName("DefaultLotCodeFormat"));
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
