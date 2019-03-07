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
                get => fCarrierID;
                set => SetPropertyValue<int>("CarrierID", ref fCarrierID, value);
            }
            private string fCarrierName;
            [Size(50)]
            public string CarrierName
            {
                get => fCarrierName;
                set => SetPropertyValue("CarrierName", ref fCarrierName, value);
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
            private string fAddress;
            [Size(150)]
            public string Address
            {
                get => fAddress;
                set => SetPropertyValue("Address", ref fAddress, value);
            }
            private string fCity;
            [Size(50)]
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
            private string fPostal;
            [Size(50)]
            public string Postal
            {
                get => fPostal;
                set => SetPropertyValue("Postal", ref fPostal, value);
            }
            private string fPhone;
            [Size(50)]
            public string Phone
            {
                get => fPhone;
                set => SetPropertyValue("Phone", ref fPhone, value);
            }
            private string fEmail;
            [Size(50)]
            public string Email
            {
                get => fEmail;
                set => SetPropertyValue("Email", ref fEmail, value);
            }
            private string fFax;
            [Size(50)]
            public string Fax
            {
                get => fFax;
                set => SetPropertyValue("Fax", ref fFax, value);
            }
            private string fNote;
            [Size(50)]
            public string Note
            {
                get => fNote;
                set => SetPropertyValue("Note", ref fNote, value);
            }
            private string fEnteredBy;
            [Size(50)]
            public string EnteredBy
            {
                get => fEnteredBy;
                set => SetPropertyValue("EnteredBy", ref fEnteredBy, value);
            }
            private DateTime fEnteredOn;
            public DateTime EnteredOn
            {
                get => fEnteredOn;
                set => SetPropertyValue<DateTime>("EnteredOn", ref fEnteredOn, value);
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

            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty CarrierID => new OperandProperty(GetNestedName("CarrierID"));
                public OperandProperty CarrierName => new OperandProperty(GetNestedName("CarrierName"));
                public OperandProperty ContactFirstName => new OperandProperty(GetNestedName("ContactFirstName"));
                public OperandProperty ContactLastName => new OperandProperty(GetNestedName("ContactLastName"));
                public OperandProperty Address => new OperandProperty(GetNestedName("Address"));
                public OperandProperty City => new OperandProperty(GetNestedName("City"));
                public OperandProperty State => new OperandProperty(GetNestedName("State"));
                public OperandProperty Postal => new OperandProperty(GetNestedName("Postal"));
                public OperandProperty Phone => new OperandProperty(GetNestedName("Phone"));
                public OperandProperty Email => new OperandProperty(GetNestedName("Email"));
                public OperandProperty Fax => new OperandProperty(GetNestedName("Fax"));
                public OperandProperty Note => new OperandProperty(GetNestedName("Note"));
                public OperandProperty EnteredBy => new OperandProperty(GetNestedName("EnteredBy"));
                public OperandProperty EnteredOn => new OperandProperty(GetNestedName("EnteredOn"));
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
