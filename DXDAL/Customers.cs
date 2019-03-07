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
            public XPCollection<UsersCustomer> AssignedUser => GetCollection<UsersCustomer>("AssignedUser");

            [Association("Customer-RelatedCustomers", typeof(RelatedCustomer))]
            [Aggregated()]
            public XPCollection<RelatedCustomer> RelatedCustomers => GetCollection<RelatedCustomer>("RelatedCustomers");

            [Association("Customer-Projects", typeof(Project))]
            [Aggregated()]
            public XPCollection<Project> Projects => GetCollection<Project>("Projects");

            public XPCollection<Items> Items => GetCollection<Items>("Items");

            [Association("Customer-Shifts", typeof(CustomerShifts))]
            [Aggregated()]
            public XPCollection<CustomerShifts> CustomerShifts => GetCollection<CustomerShifts>("CustomerShifts");

            [Association("Customer-Plants", typeof(CustomerPlants))]
            [Aggregated()]
            public XPCollection<CustomerPlants> CustomerPlants => GetCollection<CustomerPlants>("CustomerPlants");

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
                get => fCustomerID;
                set => SetPropertyValue<int>("CustomerID", ref fCustomerID, value);
            }
            private string m_CustomerName;
            [Size(50)]
            public string CustomerName
            {
                get => m_CustomerName;
                set => SetPropertyValue("CustomerName", ref m_CustomerName, value);
            }
            private string m_CustomerContact;
            [Size(50)]
            public string CustomerContact
            {
                get => m_CustomerContact;
                set => SetPropertyValue("CustomerContact", ref m_CustomerContact, value);
            }
            private string fCustomerPhone;
            [Size(50)]
            public string CustomerPhone
            {
                get => fCustomerPhone;
                set => SetPropertyValue("CustomerPhone", ref fCustomerPhone, value);
            }
            private string fCustomerEmail;
            [Size(50)]
            public string CustomerEmail
            {
                get => fCustomerEmail;
                set => SetPropertyValue("CustomerEmail", ref fCustomerEmail, value);
            }
            private string fCustomerFax;
            [Size(50)]
            public string CustomerFax
            {
                get => fCustomerFax;
                set => SetPropertyValue("CustomerFax", ref fCustomerFax, value);
            }
            private string fCustomerNote;
            [Size(250)]
            public string CustomerNote
            {
                get => fCustomerNote;
                set => SetPropertyValue("CustomerNote", ref fCustomerNote, value);
            }
            private string fstrEnteredBy;
            [Size(50)]
            public string strEnteredBy
            {
                get => fstrEnteredBy;
                set => SetPropertyValue("strEnteredBy", ref fstrEnteredBy, value);
            }
            private DateTime fdtmEnteredOn;
            public DateTime dtmEnteredOn
            {
                get => fdtmEnteredOn;
                set => SetPropertyValue<DateTime>("dtmEnteredOn", ref fdtmEnteredOn, value);
            }
            private string fAddress;
            [Size(150)]
            public string Address
            {
                get => fAddress;
                set => SetPropertyValue("Address", ref fAddress, value);
            }
            private string fCity;
            [Size(150)]
            public string City
            {
                get => fCity;
                set => SetPropertyValue("City", ref fCity, value);
            }
            private string fState;
            [Size(50)]
            public string State
            {
                get => fState;
                set => SetPropertyValue("State", ref fState, value);
            }
            private string fZipCode;
            [Size(50)]
            public string ZipCode
            {
                get => fZipCode;
                set => SetPropertyValue("ZipCode", ref fZipCode, value);
            }
            private bool fInactive;
            public bool Inactive
            {
                get => fInactive;
                set => SetPropertyValue("Inactive", ref fInactive, value);
            }
            private bool fEditing;
            public bool Editing
            {
                get => fEditing;
                set => SetPropertyValue("Editing", ref fEditing, value);
            }

            public string LPNPrefix
            {
                get => _lPNPrefix;
                set => SetPropertyValue("LPNPrefix", ref _lPNPrefix, value);
            }

            public int? FirstLPNNumber
            {
                get => _firstLPNNumber;
                set => SetPropertyValue("FirstLPNNumber", ref _firstLPNNumber, value);
            }

            public int? LastLPNNumber
            {
                get => _lastLPNNumber;
                set => SetPropertyValue("LastLPNNumber", ref _lastLPNNumber, value);
            }

            public int NextLPNNumber
            {
                get => _nextLPNNumber;
                set => SetPropertyValue<int>("NextLPNNumber", ref _nextLPNNumber, value);
            }

            public string PlantCode
            {
                get => _plantCode;
                set => SetPropertyValue("PlantCode", ref _plantCode, value);
            }

            public string ExpirationDateFormat
            {
                get
                {
                    if (string.IsNullOrEmpty(_expirationDateFormat))
                        return "MM/dd/yyyy";
                    return _expirationDateFormat;
                }
                set => SetPropertyValue("ExpirationDateFormat", ref _expirationDateFormat, value);
            }

            public LotCodeFormats DefaultLotCodeFormat
            {
                get => _defaultLotCodeFormat;
                set => SetPropertyValue("DefaultLotCodeFormat", ref _defaultLotCodeFormat, value);
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
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public const string AssignedUserFieldName = "AssignedUser";
                public OperandProperty AssignedUser => new OperandProperty(GetNestedName("AssignedUser"));
                public const string RelatedCustomersFieldName = "RelatedCustomers";
                public OperandProperty RelatedCustomers => new OperandProperty(GetNestedName("RelatedCustomers"));
                public OperandProperty CustomerID => new OperandProperty(GetNestedName("CustomerID"));
                public const string CustomerNameFieldName = "CustomerName";
                public OperandProperty CustomerName => new OperandProperty(GetNestedName("CustomerName"));
                public const string CustomerContactFieldName = "CustomerContact";
                public OperandProperty CustomerContact => new OperandProperty(GetNestedName("CustomerContact"));
                public const string CustomerPhoneFieldName = "CustomerPhone";
                public OperandProperty CustomerPhone => new OperandProperty(GetNestedName("CustomerPhone"));
                public const string CustomerEmailFieldName = "CustomerEmail";
                public OperandProperty CustomerEmail => new OperandProperty(GetNestedName("CustomerEmail"));
                public const string CustomerFaxFieldName = "CustomerFax";
                public OperandProperty CustomerFax => new OperandProperty(GetNestedName("CustomerFax"));
                public const string CustomerNoteFieldName = "CustomerNote";
                public OperandProperty CustomerNote => new OperandProperty(GetNestedName("CustomerNote"));
                public const string strEnteredByFieldName = "strEnteredBy";
                public OperandProperty strEnteredBy => new OperandProperty(GetNestedName("strEnteredBy"));
                public OperandProperty dtmEnteredOn => new OperandProperty(GetNestedName("dtmEnteredOn"));
                public const string AddressFieldName = "Address";
                public OperandProperty Address => new OperandProperty(GetNestedName("Address"));
                public const string CityFieldName = "City";
                public OperandProperty City => new OperandProperty(GetNestedName("City"));
                public const string StateFieldName = "State";
                public OperandProperty State => new OperandProperty(GetNestedName("State"));
                public const string ZipCodeFieldName = "ZipCode";
                public OperandProperty ZipCode => new OperandProperty(GetNestedName("ZipCode"));
                public OperandProperty Inactive => new OperandProperty(GetNestedName("Inactive"));
                public OperandProperty Editing => new OperandProperty(GetNestedName("Editing"));
                public const string LPNPrefixFieldName = "LPNPrefix";
                public OperandProperty LPNPrefix => new OperandProperty(GetNestedName("LPNPrefix"));
                public OperandProperty FirstLPNNumber => new OperandProperty(GetNestedName("FirstLPNNumber"));
                public OperandProperty LastLPNNumber => new OperandProperty(GetNestedName("LastLPNNumber"));
                public OperandProperty NextLPNNumber => new OperandProperty(GetNestedName("NextLPNNumber"));
                public const string PlantCodeFieldName = "PlantCode";
                public OperandProperty PlantCode => new OperandProperty(GetNestedName("PlantCode"));
                public const string ExpirationDateFormatFieldName = "ExpirationDateFormat";
                public OperandProperty ExpirationDateFormat => new OperandProperty(GetNestedName("ExpirationDateFormat"));
                public LotCodeFormats.FieldsClass DefaultLotCodeFormat => new LotCodeFormats.FieldsClass(GetNestedName("DefaultLotCodeFormat"));
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
