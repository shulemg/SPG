﻿using Microsoft.VisualBasic;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        public class ItemMachineStandards : AuditableBase
        {
            private Items fItem;
            [Association("Item-Machines")]
            public Items ProductionItem
            {
                get
                {
                    return fItem;
                }
                set
                {
                    SetPropertyValue("ProductionItem", ref fItem, value);
                }
            }

            private MachineLine fMachineLine;
            [Association("Machine-Items")]
            public MachineLine Machine
            {
                get
                {
                    return fMachineLine;
                }
                set
                {
                    SetPropertyValue("Machine", ref fMachineLine, value);
                }
            }

            private double fProductionPerMinute;
            public double ProductionPerMinute
            {
                get
                {
                    return fProductionPerMinute;
                }
                set
                {
                    SetPropertyValue("ProductionPerMinute", ref fProductionPerMinute, value);
                }
            }

            private double fMinutesPerShift;
            public double MinutesPerShift
            {
                get
                {
                    return fMinutesPerShift;
                }
                set
                {
                    SetPropertyValue("MinutesPerShift", ref fMinutesPerShift, value);
                }
            }

            private double fProjectedPackeres;
            public double ProjectedPackers
            {
                get
                {
                    //if (ProjectedPackers == null)
                    //    return 0D;

                    return fProjectedPackeres;
                }
                set
                {
                    SetPropertyValue("ProjectedPackers", ref fProjectedPackeres, value);
                }
            }
            public ItemMachineStandards() : base()
            {
            }

            public ItemMachineStandards(Session session) : base(session)
            {
            }

            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }

            public new class FieldsClass : XPLiteObject.FieldsClass
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

                public Items.FieldsClass ProductionItem
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("ProductionItem"));
                    }
                }

                public MachineLine.FieldsClass Machine
                {
                    get
                    {
                        return new MachineLine.FieldsClass(GetNestedName("Machine"));
                    }
                }

                public OperandProperty ProductionPerMinute
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ProductionPerMinute"));
                    }
                }
                public OperandProperty MinutesPerShift
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("MinutesPerShift"));
                    }
                }

                public OperandProperty ProjectedPackers
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ProjectedPackers"));
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
