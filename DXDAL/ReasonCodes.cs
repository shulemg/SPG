using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        public class ReasonCodes : AuditableBase
        {
            private string fReasonType;
            [Size(50)]
            public string ReasonType
            {
                get
                {
                    return fReasonType;
                }
                set
                {
                    SetPropertyValue("ReasonType", ref fReasonType, value);
                }
            }

            private string fReasonCode;
            [Size(50)]
            public string ReasonCode
            {
                get
                {
                    return fReasonCode;
                }
                set
                {
                    SetPropertyValue("ReasonCode", ref fReasonCode, value);
                }
            }

            private string fDescription;
            [Size(150)]
            public string Description
            {
                get
                {
                    return fDescription;
                }
                set
                {
                    SetPropertyValue("Description", ref fDescription, value);
                }
            }

            [Association("Production-Reasons")]
            public XPCollection<Production> Production
            {
                get
                {
                    return GetCollection<Production>("Production");
                }
            }
            public ReasonCodes() : base()
            {
            }

            public ReasonCodes(Session session) : base(session)
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
                public OperandProperty Oid
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Oid"));
                    }
                }
                public OperandProperty ReasonType
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ReasonType"));
                    }
                }
                public OperandProperty ReasonCode
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ReasonCode"));
                    }
                }
                public OperandProperty Description
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Description"));
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
