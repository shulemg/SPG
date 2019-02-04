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
                public OperandProperty Oid
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Oid"));
                    }
                }
                public MO.FieldsClass MO
                {
                    get
                    {
                        return new MO.FieldsClass(GetNestedName("MO"));
                    }
                }
                public MachineLine.FieldsClass MachineLine
                {
                    get
                    {
                        return new MachineLine.FieldsClass(GetNestedName("MachineLine"));
                    }
                }
                public OperandProperty StartTime
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("StartTime"));
                    }
                }
                public OperandProperty EndTime
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("EndTime"));
                    }
                }
            }
        }
    }
}
