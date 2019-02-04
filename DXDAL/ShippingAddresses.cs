using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblShippingAddresses")]
        public class ShippingAddresses : XPLiteObject
        {
            private int fAddressID;
            [Key()]
            public int AddressID
            {
                get
                {
                    return fAddressID;
                }
                set
                {
                    SetPropertyValue<int>("AddressID", ref fAddressID, value);
                }
            }
            private string fShippingName;
            [Size(50)]
            public string ShippingName
            {
                get
                {
                    return fShippingName;
                }
                set
                {
                    SetPropertyValue<string>("ShippingName", ref fShippingName, value);
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
            private string fShippingAddress;
            [Size(150)]
            public string ShippingAddress
            {
                get
                {
                    return fShippingAddress;
                }
                set
                {
                    SetPropertyValue<string>("ShippingAddress", ref fShippingAddress, value);
                }
            }
            private string fShippingCity;
            [Size(50)]
            public string ShippingCity
            {
                get
                {
                    return fShippingCity;
                }
                set
                {
                    SetPropertyValue<string>("ShippingCity", ref fShippingCity, value);
                }
            }
            private string fShippingState;
            [Size(50)]
            public string ShippingState
            {
                get
                {
                    return fShippingState;
                }
                set
                {
                    SetPropertyValue<string>("ShippingState", ref fShippingState, value);
                }
            }
            private string fShippingPostal;
            [Size(50)]
            public string ShippingPostal
            {
                get
                {
                    return fShippingPostal;
                }
                set
                {
                    SetPropertyValue<string>("ShippingPostal", ref fShippingPostal, value);
                }
            }
            private string fShippingPhone;
            [Size(50)]
            public string ShippingPhone
            {
                get
                {
                    return fShippingPhone;
                }
                set
                {
                    SetPropertyValue<string>("ShippingPhone", ref fShippingPhone, value);
                }
            }
            private string fShippingEmail;
            [Size(50)]
            public string ShippingEmail
            {
                get
                {
                    return fShippingEmail;
                }
                set
                {
                    SetPropertyValue<string>("ShippingEmail", ref fShippingEmail, value);
                }
            }
            private string fShippingFax;
            [Size(50)]
            public string ShippingFax
            {
                get
                {
                    return fShippingFax;
                }
                set
                {
                    SetPropertyValue<string>("ShippingFax", ref fShippingFax, value);
                }
            }
            private string fShippingNote;
            [Size(50)]
            public string ShippingNote
            {
                get
                {
                    return fShippingNote;
                }
                set
                {
                    SetPropertyValue<string>("ShippingNote", ref fShippingNote, value);
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
            public ShippingAddresses(Session session) : base(session)
            {
            }
            public ShippingAddresses() : base(Session.DefaultSession)
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
                public OperandProperty AddressID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("AddressID"));
                    }
                }
                public OperandProperty ShippingName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShippingName"));
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
                public OperandProperty ShippingAddress
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShippingAddress"));
                    }
                }
                public OperandProperty ShippingCity
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShippingCity"));
                    }
                }
                public OperandProperty ShippingState
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShippingState"));
                    }
                }
                public OperandProperty ShippingPostal
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShippingPostal"));
                    }
                }
                public OperandProperty ShippingPhone
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShippingPhone"));
                    }
                }
                public OperandProperty ShippingEmail
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShippingEmail"));
                    }
                }
                public OperandProperty ShippingFax
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShippingFax"));
                    }
                }
                public OperandProperty ShippingNote
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShippingNote"));
                    }
                }
                public OperandProperty strEnteredBy
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strEnteredBy"));
                    }
                }
                public OperandProperty dtmEnteredOn
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dtmEnteredOn"));
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
