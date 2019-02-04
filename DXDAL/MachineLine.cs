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
                get
                {
                    return fMachineLineID;
                }
                set
                {
                    SetPropertyValue<int>("MachineLineID", ref fMachineLineID, value);
                }
            }
            private string fMachineLineName;
            [Size(50)]
            public string MachineLineName
            {
                get
                {
                    return fMachineLineName;
                }
                set
                {
                    SetPropertyValue<string>("MachineLineName", ref fMachineLineName, value);
                }
            }

            [Association("Machine-Items", typeof(ItemMachineStandards))]
            [Aggregated()]
            public XPCollection<ItemMachineStandards> MachineItems
            {
                get
                {
                    return GetCollection<ItemMachineStandards>("MachineItems");
                }
            }
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
            public new class FieldsClass : DevExpress.Xpo.PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty fMachineLineID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("fMachineLineID"));
                    }
                }
                public OperandProperty MachineLineID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("MachineLineID"));
                    }
                }
                public OperandProperty fMachineLineName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("fMachineLineName"));
                    }
                }
                public OperandProperty MachineLineName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("MachineLineName"));
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
