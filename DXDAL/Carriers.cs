using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblCarriers")]
        public class Carriers : XPLiteObject
        {
            private int fCarrierID;
            [Key()]
            public int CarrierID
            {
                get
                {
                    return fCarrierID;
                }
                set
                {
                    SetPropertyValue<int>("CarrierID", ref fCarrierID, value);
                }
            }
            private string fCarrierName;
            [Size(50)]
            public string CarrierName
            {
                get
                {
                    return fCarrierName;
                }
                set
                {
                    SetPropertyValue<string>("CarrierName", ref fCarrierName, value);
                }
            }
            private string fContactFirstName;
            [Size(50)]
            public string ContactFirstName
            {
                get
                {
                    return fContactFirstName;
                }
                set
                {
                    SetPropertyValue<string>("ContactFirstName", ref fContactFirstName, value);
                }
            }
            private string fContactLastName;
            [Size(50)]
            public string ContactLastName
            {
                get
                {
                    return fContactLastName;
                }
                set
                {
                    SetPropertyValue<string>("ContactLastName", ref fContactLastName, value);
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
            [Size(50)]
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
            private string fPostal;
            [Size(50)]
            public string Postal
            {
                get
                {
                    return fPostal;
                }
                set
                {
                    SetPropertyValue<string>("Postal", ref fPostal, value);
                }
            }
            private string fPhone;
            [Size(50)]
            public string Phone
            {
                get
                {
                    return fPhone;
                }
                set
                {
                    SetPropertyValue<string>("Phone", ref fPhone, value);
                }
            }
            private string fEmail;
            [Size(50)]
            public string Email
            {
                get
                {
                    return fEmail;
                }
                set
                {
                    SetPropertyValue<string>("Email", ref fEmail, value);
                }
            }
            private string fFax;
            [Size(50)]
            public string Fax
            {
                get
                {
                    return fFax;
                }
                set
                {
                    SetPropertyValue<string>("Fax", ref fFax, value);
                }
            }
            private string fNote;
            [Size(50)]
            public string Note
            {
                get
                {
                    return fNote;
                }
                set
                {
                    SetPropertyValue<string>("Note", ref fNote, value);
                }
            }
            private string fEnteredBy;
            [Size(50)]
            public string EnteredBy
            {
                get
                {
                    return fEnteredBy;
                }
                set
                {
                    SetPropertyValue<string>("EnteredBy", ref fEnteredBy, value);
                }
            }
            private DateTime fEnteredOn;
            public DateTime EnteredOn
            {
                get
                {
                    return fEnteredOn;
                }
                set
                {
                    SetPropertyValue<DateTime>("EnteredOn", ref fEnteredOn, value);
                }
            }
            public Carriers(Session session) : base(session)
            {
            }
            public Carriers() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }

            public new class FieldsClass : XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty CarrierID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CarrierID"));
                    }
                }
                public OperandProperty CarrierName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CarrierName"));
                    }
                }
                public OperandProperty ContactFirstName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ContactFirstName"));
                    }
                }
                public OperandProperty ContactLastName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ContactLastName"));
                    }
                }
                public OperandProperty Address
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Address"));
                    }
                }
                public OperandProperty City
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("City"));
                    }
                }
                public OperandProperty State
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("State"));
                    }
                }
                public OperandProperty Postal
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Postal"));
                    }
                }
                public OperandProperty Phone
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Phone"));
                    }
                }
                public OperandProperty Email
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Email"));
                    }
                }
                public OperandProperty Fax
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Fax"));
                    }
                }
                public OperandProperty Note
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Note"));
                    }
                }
                public OperandProperty EnteredBy
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("EnteredBy"));
                    }
                }
                public OperandProperty EnteredOn
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("EnteredOn"));
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
