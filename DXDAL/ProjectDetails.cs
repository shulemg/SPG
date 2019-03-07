using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class ProjectDetails : AuditableBase
        {

            // Fields...
            private bool _allowOverrun;
            // Private _percentageComplete As Decimal
            // Private _palletsProduced As Integer
            // Private _bagsProduced As Integer
            // Private _unitsProduced As Integer
            private int _palletsRequested;
            private int _bagsRequested;
            private int _unitsRequested;
            private Items _projectItem;
            private string _customerPO;
            private Project _project;

            [Association("Project-Details")]
            public Project Project
            {
                get => _project;
                set => SetPropertyValue("Project", ref _project, value);
            }

            public string CustomerPO
            {
                get => _customerPO;
                set => SetPropertyValue("CustomerPO", ref _customerPO, value);
            }

            public Items ProjectItem
            {
                get => _projectItem;
                set => SetPropertyValue("ProjectItem", ref _projectItem, value);
            }

            public int UnitsRequested
            {
                get => _unitsRequested;
                set => SetPropertyValue<int>("UnitsRequested", ref _unitsRequested, value);
            }

            public int BagsRequested
            {
                get => _bagsRequested;
                set => SetPropertyValue<int>("BagsRequested", ref _bagsRequested, value);
            }

            public int PalletsRequested
            {
                get => _palletsRequested;
                set => SetPropertyValue<int>("PalletsRequested", ref _palletsRequested, value);
            }

            public bool AllowOverrun
            {
                get => _allowOverrun;
                set => SetPropertyValue("AllowOverrun", ref _allowOverrun, value);
            }

            [Association("MO-ProjectDetail", typeof(MO))]
            [Aggregated()]
            public XPCollection<MO> ProjectMO => GetCollection<MO>("ProjectMO");

            [Association("Production-ProjectDetail", typeof(ProductionProjectDetails))]
            [Aggregated()]
            public XPCollection<ProductionProjectDetails> ProjectProduction => GetCollection<ProductionProjectDetails>("ProjectProduction");

            [Association("Project-ProductionSchedule", typeof(ProductionSchedule))]
            [Aggregated()]
            public XPCollection<ProductionSchedule> ProjectProductionSchedule => GetCollection<ProductionSchedule>("ProjectProductionSchedule");

            [PersistentAlias("IsNull(ProjectProduction.Sum(UnitsProduced), 0)")]
            public int UnitsProduced => Convert.ToInt32(EvaluateAlias("UnitsProduced"));

            [PersistentAlias("IsNull(ProjectProductionSchedule.Sum(Quantity), 0)")]
            public int UnitsScheduled => Convert.ToInt32(EvaluateAlias("UnitsScheduled"));

            // used to identify if there's still units needed to produce
            public int UnitsNeeded => Math.Max(UnitsRequested - UnitsProduced, 0);

            // Used to identify if there's still units needed to be scheduled
            public int UnitsNeededToSchedule => Math.Max(UnitsRequested - Math.Max(UnitsProduced, UnitsScheduled), 0);

            [PersistentAlias("ProjectProduction.Sum(BagsProduced)")]
            public int BagsProduced => Convert.ToInt32(EvaluateAlias("BagsProduced"));

            [PersistentAlias("ProjectProduction.Sum(PalletsProduced)")]
            public int PalletsProduced => Convert.ToInt32(EvaluateAlias("PalletsProduced"));

            public double PercentageComplete
            {
                get
                {
                    if (UnitsProduced == 0 || UnitsRequested == 0)
                        return 0;

                    return UnitsProduced / (double)UnitsRequested * 100;
                }
            }

            public double RemainingBalance => UnitsRequested - UnitsProduced;

            public double? EstimatedShifts
            {
                get
                {
                    if (ProjectItem == null || RemainingBalance == 0 || ProjectItem.ItemProdStandard.HasValue == false || ProjectItem.ItemProdStandard.Value == 0)
                        return default(double?);

                    return (RemainingBalance * ProjectItem.intQtyPerUnit) / (ProjectItem.ItemProdStandard.Value * 358.3333);     // 7:10 * 50 min per hour
                }
            }

            public ProjectDetails() : base()
            {
            }

            public ProjectDetails(Session session) : base(session)
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
                public Project.FieldsClass Project => new Project.FieldsClass(GetNestedName("Project"));
                public OperandProperty CustomerPO => new OperandProperty(GetNestedName("CustomerPO"));
                public Items.FieldsClass ProjectItem => new Items.FieldsClass(GetNestedName("ProjectItem"));
                public OperandProperty UnitsRequested => new OperandProperty(GetNestedName("UnitsRequested"));
                public OperandProperty BagsRequested => new OperandProperty(GetNestedName("BagsRequested"));
                public OperandProperty PalletsRequested => new OperandProperty(GetNestedName("PalletsRequested"));
                public OperandProperty UnitsProduced => new OperandProperty(GetNestedName("UnitsProduced"));
                public OperandProperty BagsProduced => new OperandProperty(GetNestedName("BagsProduced"));
                public OperandProperty PalletsProduced => new OperandProperty(GetNestedName("PalletsProduced"));
                public OperandProperty PercentageComplete => new OperandProperty(GetNestedName("PercentageComplete"));
                public OperandProperty AllowOverrun => new OperandProperty(GetNestedName("AllowOverrun"));
                public OperandProperty EstimatedShifts => new OperandProperty(GetNestedName("EstimatedShifts"));
                public OperandProperty UnitsScheduled => new OperandProperty(GetNestedName("UnitsScheduled"));
                public OperandProperty UnitsNeeded => new OperandProperty(GetNestedName("UnitsNeeded"));
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
