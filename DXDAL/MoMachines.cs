using System;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblMoMachineLine")]
        public class MoMachineLine : AuditableBase
        {
            [Association("MO-MachineLines")]
            public MO Mo { get; set; }
            public MachineLine MachineLine { get; set; }
            public DateTime? StartTime { get; set; }
            public DateTime? EndTime { get; set; }

            public MoMachineLine() : base()
            {
            }
            public MoMachineLine(Session session) : base(session)
            {
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
                public MO.FieldsClass Mo => new MO.FieldsClass(GetNestedName("Mo"));
                public MachineLine.FieldsClass MachineLine => new MachineLine.FieldsClass(GetNestedName("MachineLine"));
                public OperandProperty StartTime => new OperandProperty(GetNestedName("StartTime"));
                public OperandProperty EndTime => new OperandProperty(GetNestedName("EndTime"));
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
