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
                get => _finish;
                set => SetPropertyValue<DateTime>("Finish", ref _finish, value);
            }

            public DateTime Start
            {
                get => _start;
                set => SetPropertyValue<DateTime>("Start", ref _start, value);
            }

            public MachineLine MachineLine
            {
                get => _machineLine;
                set => SetPropertyValue("MachineLine", ref _machineLine, value);
            }

            public double? People
            {
                get => _people;
                set => SetPropertyValue("People", ref _people, value);
            }

            public double? MachineOperator
            {
                get => _machineOperator;
                set => SetPropertyValue("MachineOperator", ref _machineOperator, value);
            }

            public Items ProductionItem
            {
                get => _productionItem;
                set => SetPropertyValue("ProductionItem", ref _productionItem, value);
            }

            public bool? MustRun
            {
                get => _mustRun;
                set => SetPropertyValue("MustRun", ref _mustRun, value);
            }

            public int? PriorityLevel
            {
                get => _priorityLevel;
                set => SetPropertyValue("PriorityLevel", ref _priorityLevel, value);
            }

            public Project Project
            {
                get => _project;
                set => SetPropertyValue("Project", ref _project, value);
            }

            [Association("Project-ProductionSchedule")]
            public ProjectDetails ProjectDetail
            {
                get => _projectDetail;
                set => SetPropertyValue("ProjectDetail", ref _projectDetail, value);
            }

            [Size(SizeAttribute.Unlimited)]
            public string ScheduleNote
            {
                get => _scheduleNote;
                set => SetPropertyValue("ScheduleNote", ref _scheduleNote, value);
            }

            public double Quantity
            {
                get => _Quantity;
                set => SetPropertyValue("Quantity", ref _Quantity, value);
            }

            public bool ScheduleByQuantity
            {
                get => _scheduleByQuantity;
                set => SetPropertyValue("ScheduleByQuantity", ref _scheduleByQuantity, value);
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

            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty Oid => new OperandProperty(GetNestedName("Oid"));
                public OperandProperty Finish => new OperandProperty(GetNestedName("Finish"));
                public OperandProperty Start => new OperandProperty(GetNestedName("Start"));
                public MachineLine.FieldsClass MachineLine => new MachineLine.FieldsClass(GetNestedName("MachineLine"));
                public OperandProperty People => new OperandProperty(GetNestedName("People"));
                public OperandProperty MachineOperator => new OperandProperty(GetNestedName("MachineOperator"));
                public Items.FieldsClass ProductionItem => new Items.FieldsClass(GetNestedName("ProductionItem"));
                public OperandProperty MustRun => new OperandProperty(GetNestedName("MustRun"));
                public OperandProperty PriorityLevel => new OperandProperty(GetNestedName("PriorityLevel"));
                public Project.FieldsClass Project => new Project.FieldsClass(GetNestedName("Project"));
                public ProjectDetails.FieldsClass ProjectDetail => new ProjectDetails.FieldsClass(GetNestedName("ProjectDetail"));
                public OperandProperty ScheduleNote => new OperandProperty(GetNestedName("ScheduleNote"));
                public OperandProperty Quantity => new OperandProperty(GetNestedName("Quantity"));
                public OperandProperty ScheduleByQuantity => new OperandProperty(GetNestedName("ScheduleByQuantity"));
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
