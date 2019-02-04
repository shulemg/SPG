using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        public class LotCodeSectionSettings : AuditableBase
        {
            private LotCodeFormatSections fLotCodeSection;
            [Association("Section-Settings")]
            public LotCodeFormatSections LotCodeSection
            {
                get
                {
                    return fLotCodeSection;
                }
                set
                {
                    SetPropertyValue("LotCodeSection", ref fLotCodeSection, value);
                }
            }

            private string fSettingName;
            [Size(50)]
            public string SettingName
            {
                get
                {
                    return fSettingName;
                }
                set
                {
                    SetPropertyValue("SettingName", ref fSettingName, value);
                }
            }

            private string fSettingValue;
            [Size(100)]
            public string SettingValue
            {
                get
                {
                    return fSettingValue;
                }
                set
                {
                    SetPropertyValue("SettingValue", ref fSettingValue, value);
                }
            }
            public LotCodeSectionSettings() : base()
            {
            }

            public LotCodeSectionSettings(Session session) : base(session)
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
                public LotCodeFormatSections.FieldsClass LotCodeSection
                {
                    get
                    {
                        return new LotCodeFormatSections.FieldsClass(GetNestedName("LotCodeSection"));
                    }
                }
                public OperandProperty SettingName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("SettingName"));
                    }
                }
                public OperandProperty SettingValue
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("SettingValue"));
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
