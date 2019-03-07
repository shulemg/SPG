using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        public class CustomerShifts : AuditableBase
        {
            private Customers fCustomer;
            [Association("Customer-Shifts")]
            public Customers Customer
            {
                get => fCustomer;
                set => SetPropertyValue("Customer", ref fCustomer, value);
            }

            private string fShiftName;
            [Size(150)]
            public string ShiftName
            {
                get => fShiftName;
                set => SetPropertyValue("ShiftName", ref fShiftName, value);
            }

            private string fShiftCode;
            [Size(10)]
            public string ShiftCode
            {
                get => fShiftCode;
                set => SetPropertyValue("ShiftCode", ref fShiftCode, value);
            }

            private Shifts fSPGShift;
            public Shifts SPGShift
            {
                get => fSPGShift;
                set => SetPropertyValue("SPGShift", ref fSPGShift, value);
            }

            public CustomerShifts() : base()
            {
            }

            public CustomerShifts(Session session) : base(session)
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
                public Customers.FieldsClass Customer => new Customers.FieldsClass(GetNestedName("Customer"));
                public OperandProperty ShiftName => new OperandProperty(GetNestedName("ShiftName"));
                public OperandProperty ShiftCode => new OperandProperty(GetNestedName("ShiftCode"));
                public Shifts.FieldsClass SPGShift => new Shifts.FieldsClass(GetNestedName("SPGShift"));
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
