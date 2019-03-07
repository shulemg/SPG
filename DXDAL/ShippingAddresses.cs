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
                get => fAddressID;
                set => SetPropertyValue<int>("AddressID", ref fAddressID, value);
            }
            private string fShippingName;
            [Size(50)]
            public string ShippingName
            {
                get => fShippingName;
                set => SetPropertyValue("ShippingName", ref fShippingName, value);
            }
            private string fContactFirstName;
            [Size(50)]
            public string ContactFirstName
            {
                get => fContactFirstName;
                set => SetPropertyValue("ContactFirstName", ref fContactFirstName, value);
            }
            private string fContactLastName;
            [Size(50)]
            public string ContactLastName
            {
                get => fContactLastName;
                set => SetPropertyValue("ContactLastName", ref fContactLastName, value);
            }
            private string fShippingAddress;
            [Size(150)]
            public string ShippingAddress
            {
                get => fShippingAddress;
                set => SetPropertyValue("ShippingAddress", ref fShippingAddress, value);
            }
            private string fShippingCity;
            [Size(50)]
            public string ShippingCity
            {
                get => fShippingCity;
                set => SetPropertyValue("ShippingCity", ref fShippingCity, value);
            }
            private string fShippingState;
            [Size(50)]
            public string ShippingState
            {
                get => fShippingState;
                set => SetPropertyValue("ShippingState", ref fShippingState, value);
            }
            private string fShippingPostal;
            [Size(50)]
            public string ShippingPostal
            {
                get => fShippingPostal;
                set => SetPropertyValue("ShippingPostal", ref fShippingPostal, value);
            }
            private string fShippingPhone;
            [Size(50)]
            public string ShippingPhone
            {
                get => fShippingPhone;
                set => SetPropertyValue("ShippingPhone", ref fShippingPhone, value);
            }
            private string fShippingEmail;
            [Size(50)]
            public string ShippingEmail
            {
                get => fShippingEmail;
                set => SetPropertyValue("ShippingEmail", ref fShippingEmail, value);
            }
            private string fShippingFax;
            [Size(50)]
            public string ShippingFax
            {
                get => fShippingFax;
                set => SetPropertyValue("ShippingFax", ref fShippingFax, value);
            }
            private string fShippingNote;
            [Size(50)]
            public string ShippingNote
            {
                get => fShippingNote;
                set => SetPropertyValue("ShippingNote", ref fShippingNote, value);
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
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty AddressID => new OperandProperty(GetNestedName("AddressID"));
                public OperandProperty ShippingName => new OperandProperty(GetNestedName("ShippingName"));
                public OperandProperty ContactFirstName => new OperandProperty(GetNestedName("ContactFirstName"));
                public OperandProperty ContactLastName => new OperandProperty(GetNestedName("ContactLastName"));
                public OperandProperty ShippingAddress => new OperandProperty(GetNestedName("ShippingAddress"));
                public OperandProperty ShippingCity => new OperandProperty(GetNestedName("ShippingCity"));
                public OperandProperty ShippingState => new OperandProperty(GetNestedName("ShippingState"));
                public OperandProperty ShippingPostal => new OperandProperty(GetNestedName("ShippingPostal"));
                public OperandProperty ShippingPhone => new OperandProperty(GetNestedName("ShippingPhone"));
                public OperandProperty ShippingEmail => new OperandProperty(GetNestedName("ShippingEmail"));
                public OperandProperty ShippingFax => new OperandProperty(GetNestedName("ShippingFax"));
                public OperandProperty ShippingNote => new OperandProperty(GetNestedName("ShippingNote"));
                public OperandProperty strEnteredBy => new OperandProperty(GetNestedName("strEnteredBy"));
                public OperandProperty dtmEnteredOn => new OperandProperty(GetNestedName("dtmEnteredOn"));
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
