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
                get
                {
                    return fID;
                }
                set
                {
                    SetPropertyValue<int>("ID", ref fID, value);
                }
            }
            private string fName;
            [Size(SizeAttribute.Unlimited)]
            public string Name
            {
                get
                {
                    return fName;
                }
                set
                {
                    SetPropertyValue<string>("Name", ref fName, value);
                }
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
            public new class FieldsClass : DevExpress.Xpo.XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public DevExpress.Data.Filtering.OperandProperty ID
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ID"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty Name
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("Name"));
                    }
                }
            }
        }
    }
}
