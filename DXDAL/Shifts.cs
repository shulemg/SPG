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
                get => fShiftID;
                set => SetPropertyValue<int>("ShiftID", ref fShiftID, value);
            }
            private string fShiftName;
            [Size(50)]
            public string ShiftName
            {
                get => fShiftName;
                set => SetPropertyValue("ShiftName", ref fShiftName, value);
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
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public DevExpress.Data.Filtering.OperandProperty ShiftID => new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShiftID"));
                public DevExpress.Data.Filtering.OperandProperty ShiftName => new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShiftName"));
            }
        }
    }
}
