using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblMachineLine")]
        public class MachineLine : XPLiteObject
        {
            private int fMachineLineID;
            [Key(true)]
            public int MachineLineID
            {
                get => fMachineLineID;
                set => SetPropertyValue<int>("MachineLineID", ref fMachineLineID, value);
            }
            private string fMachineLineName;
            [Size(50)]
            public string MachineLineName
            {
                get => fMachineLineName;
                set => SetPropertyValue("MachineLineName", ref fMachineLineName, value);
            }

            [Association("Machine-Items", typeof(ItemMachineStandards))]
            [Aggregated()]
            public XPCollection<ItemMachineStandards> MachineItems => GetCollection<ItemMachineStandards>("MachineItems");
            public MachineLine(Session session) : base(session)
            {
            }
            public MachineLine() : base(Session.DefaultSession)
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
                public OperandProperty fMachineLineID => new OperandProperty(GetNestedName("fMachineLineID"));
                public OperandProperty MachineLineID => new OperandProperty(GetNestedName("MachineLineID"));
                public OperandProperty fMachineLineName => new OperandProperty(GetNestedName("fMachineLineName"));
                public OperandProperty MachineLineName => new OperandProperty(GetNestedName("MachineLineName"));
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
