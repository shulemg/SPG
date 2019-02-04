using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        public class LotCodeFormatSections : AuditableBase
        {
            private LotCodeFormats fLotCodeFormat;
            [Association("Format-Sections")]
            public LotCodeFormats LotCodeFormat
            {
                get
                {
                    return fLotCodeFormat;
                }
                set
                {
                    SetPropertyValue("LotCodeFormat", ref fLotCodeFormat, value);
                }
            }

            private string fSectionName;
            [Size(50)]
            public string SectionName
            {
                get
                {
                    return fSectionName;
                }
                set
                {
                    SetPropertyValue("SectionName", ref fSectionName, value);
                }
            }

            private LotCodeSectionType fSectionType;
            public LotCodeSectionType SectionType
            {
                get
                {
                    return fSectionType;
                }
                set
                {
                    SetPropertyValue("SectionType", ref fSectionType, value);
                }
            }

            private int fSectionLength;
            public int SectionLength
            {
                get
                {
                    return fSectionLength;
                }
                set
                {
                    SetPropertyValue<int>("SectionLength", ref fSectionLength, value);
                }
            }

            private int fSectionPosition;
            public int SectionPosition
            {
                get
                {
                    return fSectionPosition;
                }
                set
                {
                    SetPropertyValue<int>("SectionPosition", ref fSectionPosition, value);
                }
            }

            [Association("Section-Settings", typeof(LotCodeSectionSettings))]
            [Aggregated()]
            public XPCollection<LotCodeSectionSettings> SectionSettings
            {
                get
                {
                    return GetCollection<LotCodeSectionSettings>("SectionSettings");
                }
            }
            public LotCodeFormatSections() : base()
            {
            }

            public LotCodeFormatSections(Session session) : base(session)
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
                public LotCodeFormats.FieldsClass LotCodeFormat
                {
                    get
                    {
                        return new LotCodeFormats.FieldsClass(GetNestedName("LotCodeFormat"));
                    }
                }
                public OperandProperty SectionName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("SectionName"));
                    }
                }
                public OperandProperty SectionType
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("SectionType"));
                    }
                }
                public OperandProperty SectionLength
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("SectionLength"));
                    }
                }
                public OperandProperty SectionPosition
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("SectionPosition"));
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
