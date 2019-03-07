using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblMO")]
        public class MO : AuditableBase
        {
            [Association("MO-ProjectDetail")]
            public ProjectDetails ProjectDetail { get; set; }
            [Association("MO-MachineLines", typeof(MoMachineLine))]
            [Aggregated]
            public XPCollection<MoMachineLine> MoMachineLines => GetCollection<MoMachineLine>("MoMachineLines");
            public MOStatus Status { get; set; }
            public DateTime? ScheduledStartDateTime { get; set; }

            public MO() : base()
            {
            }

            public MO(Session session) : base(session)
            {
            }

            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }

            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty Oid => new OperandProperty(GetNestedName("Oid"));
                public ProjectDetails.FieldsClass ProjectDetail => new ProjectDetails.FieldsClass(GetNestedName("ProjectDetail"));
                public OperandProperty Status => new OperandProperty(GetNestedName("Status"));
                public OperandProperty ScheduledStartDateTime => new OperandProperty(GetNestedName("ScheduledStartDateTime"));
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

        public enum MOStatus
        {
            Scheduled,
            Active,
            Finished
        }
    }
}
