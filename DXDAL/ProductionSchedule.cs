using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class ProductionSchedule : AuditableBase
        {
            private DateTime _finish;
            private DateTime _start;
            private MachineLine _machineLine;
            private double? _people;
            private double? _machineOperator;
            private Items _productionItem;
            private bool? _mustRun;
            private int? _priorityLevel;
            private Project _project;
            private ProjectDetails _projectDetail;
            private string _scheduleNote;
            private double _Quantity;
            private bool _scheduleByQuantity;

            public DateTime Finish
            {
                get
                {
                    return _finish;
                }
                set
                {
                    SetPropertyValue<DateTime>("Finish", ref _finish, value);
                }
            }

            public DateTime Start
            {
                get
                {
                    return _start;
                }
                set
                {
                    SetPropertyValue<DateTime>("Start", ref _start, value);
                }
            }

            public MachineLine MachineLine
            {
                get
                {
                    return _machineLine;
                }
                set
                {
                    SetPropertyValue<MachineLine>("MachineLine", ref _machineLine, value);
                }
            }

            public double? People
            {
                get
                {
                    return _people;
                }
                set
                {
                    SetPropertyValue<double?>("People", ref _people, value);
                }
            }

            public double? MachineOperator
            {
                get
                {
                    return _machineOperator;
                }
                set
                {
                    SetPropertyValue<double?>("MachineOperator", ref _machineOperator, value);
                }
            }

            public Items ProductionItem
            {
                get
                {
                    return _productionItem;
                }
                set
                {
                    SetPropertyValue<Items>("ProductionItem", ref _productionItem, value);
                }
            }

            public bool? MustRun
            {
                get
                {
                    return _mustRun;
                }
                set
                {
                    SetPropertyValue<bool?>("MustRun", ref _mustRun, value);
                }
            }

            public int? PriorityLevel
            {
                get
                {
                    return _priorityLevel;
                }
                set
                {
                    SetPropertyValue<int?>("PriorityLevel", ref _priorityLevel, value);
                }
            }

            public Project Project
            {
                get
                {
                    return _project;
                }
                set
                {
                    SetPropertyValue<Project>("Project", ref _project, value);
                }
            }

            [Association("Project-ProductionSchedule")]
            public ProjectDetails ProjectDetail
            {
                get
                {
                    return _projectDetail;
                }
                set
                {
                    SetPropertyValue<ProjectDetails>("ProjectDetail", ref _projectDetail, value);
                }
            }

            [Size(SizeAttribute.Unlimited)]
            public string ScheduleNote
            {
                get
                {
                    return _scheduleNote;
                }
                set
                {
                    SetPropertyValue<string>("ScheduleNote", ref _scheduleNote, value);
                }
            }

            public double Quantity
            {
                get
                {
                    return _Quantity;
                }
                set
                {
                    SetPropertyValue<double>("Quantity", ref _Quantity, value);
                }
            }

            public bool ScheduleByQuantity
            {
                get
                {
                    return _scheduleByQuantity;
                }
                set
                {
                    SetPropertyValue<bool>("ScheduleByQuantity", ref _scheduleByQuantity, value);
                }
            }

            public string ScheduleTitle
            {
                get
                {
                    if (Project != null && ProductionItem != null)
                        return string.Format("{0} - {1}", Project.project, ProductionItem.ItemCode);
                    else if (ProductionItem != null)
                        return ProductionItem.ItemCode;
                    else if (Project != null)
                        return Project.project;
                    else
                        return string.Empty;
                }
            }

            public ProductionSchedule() : base()
            {
            }

            public ProductionSchedule(Session session) : base(session)
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
                public OperandProperty Oid
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Oid"));
                    }
                }
                public OperandProperty Finish
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Finish"));
                    }
                }
                public OperandProperty Start
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Start"));
                    }
                }
                public MachineLine.FieldsClass MachineLine
                {
                    get
                    {
                        return new MachineLine.FieldsClass(GetNestedName("MachineLine"));
                    }
                }
                public OperandProperty People
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("People"));
                    }
                }
                public OperandProperty MachineOperator
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("MachineOperator"));
                    }
                }
                public Items.FieldsClass ProductionItem
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("ProductionItem"));
                    }
                }
                public OperandProperty MustRun
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("MustRun"));
                    }
                }
                public OperandProperty PriorityLevel
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PriorityLevel"));
                    }
                }
                public Project.FieldsClass Project
                {
                    get
                    {
                        return new Project.FieldsClass(GetNestedName("Project"));
                    }
                }
                public ProjectDetails.FieldsClass ProjectDetail
                {
                    get
                    {
                        return new ProjectDetails.FieldsClass(GetNestedName("ProjectDetail"));
                    }
                }
                public OperandProperty ScheduleNote
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ScheduleNote"));
                    }
                }
                public OperandProperty Quantity
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Quantity"));
                    }
                }
                public OperandProperty ScheduleByQuantity
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ScheduleByQuantity"));
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
