using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblTest")]
        public class Tests : XPLiteObject
        {
            private int fID;
            [Key(true)]
            public int ID
            {
                get => fID;
                set => SetPropertyValue<int>("ID", ref fID, value);
            }
            private string fName;
            [Size(SizeAttribute.Unlimited)]
            public string Name
            {
                get => fName;
                set => SetPropertyValue("Name", ref fName, value);
            }


            public Tests(Session session) : base(session)
            {
            }
            public Tests() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
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
            // Created/Updated: Joel-PC\Joel on JOEL-PC at 7/06/10 4:40 PM
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public DevExpress.Data.Filtering.OperandProperty ID => new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ID"));
                public DevExpress.Data.Filtering.OperandProperty Name => new DevExpress.Data.Filtering.OperandProperty(GetNestedName("Name"));
            }
        }
    }
}
