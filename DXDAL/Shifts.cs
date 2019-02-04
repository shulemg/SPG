using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblShifts")]
        public class Shifts : XPLiteObject
        {
            private int fShiftID;
            [Key(true)]
            public int ShiftID
            {
                get
                {
                    return fShiftID;
                }
                set
                {
                    SetPropertyValue<int>("ShiftID", ref fShiftID, value);
                }
            }
            private string fShiftName;
            [Size(50)]
            public string ShiftName
            {
                get
                {
                    return fShiftName;
                }
                set
                {
                    SetPropertyValue<string>("ShiftName", ref fShiftName, value);
                }
            }


            public Shifts(Session session) : base(session)
            {
            }
            public Shifts() : base(Session.DefaultSession)
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
                public DevExpress.Data.Filtering.OperandProperty ShiftID
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShiftID"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty ShiftName
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShiftName"));
                    }
                }
            }
        }
    }
}
