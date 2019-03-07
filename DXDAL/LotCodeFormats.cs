using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        public class LotCodeFormats : AuditableBase
        {
            private string fFormatName;
            [Size(50)]
            public string FormatName
            {
                get => fFormatName;
                set => SetPropertyValue("FormatName", ref fFormatName, value);
            }

            private int fSections;
            public int Sections
            {
                get => fSections;
                set => SetPropertyValue<int>("Sections", ref fSections, value);
            }

            [Association("Format-Sections", typeof(LotCodeFormatSections))]
            [Aggregated()]
            public XPCollection<LotCodeFormatSections> FormatSections => GetCollection<LotCodeFormatSections>("FormatSections");
            public LotCodeFormats() : base()
            {
            }

            public LotCodeFormats(Session session) : base(session)
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
                public OperandProperty Oid => new OperandProperty(GetNestedName("Oid"));
                public OperandProperty FormatName => new OperandProperty(GetNestedName("FormatName"));
                public OperandProperty Sections => new OperandProperty(GetNestedName("Sections"));
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
