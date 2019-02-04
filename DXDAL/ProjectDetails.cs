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
                get
                {
                    return _project;
                }
                set
                {
                    SetPropertyValue("Project", ref _project, value);
                }
            }

            public string CustomerPO
            {
                get
                {
                    return _customerPO;
                }
                set
                {
                    SetPropertyValue("CustomerPO", ref _customerPO, value);
                }
            }

            public Items ProjectItem
            {
                get
                {
                    return _projectItem;
                }
                set
                {
                    SetPropertyValue("ProjectItem", ref _projectItem, value);
                }
            }

            public int UnitsRequested
            {
                get
                {
                    return _unitsRequested;
                }
                set
                {
                    SetPropertyValue<int>("UnitsRequested", ref _unitsRequested, value);
                }
            }

            public int BagsRequested
            {
                get
                {
                    return _bagsRequested;
                }
                set
                {
                    SetPropertyValue<int>("BagsRequested", ref _bagsRequested, value);
                }
            }

            public int PalletsRequested
            {
                get
                {
                    return _palletsRequested;
                }
                set
                {
                    SetPropertyValue<int>("PalletsRequested", ref _palletsRequested, value);
                }
            }

            public bool AllowOverrun
            {
                get
                {
                    return _allowOverrun;
                }
                set
                {
                    SetPropertyValue("AllowOverrun", ref _allowOverrun, value);
                }
            }

            [Association("MO-ProjectDetail", typeof(MO))]
            [Aggregated()]
            public XPCollection<MO> ProjectMO
            {
                get
                {
                    return GetCollection<MO>("ProjectMO");
                }
            }

            [Association("Production-ProjectDetail", typeof(ProductionProjectDetails))]
            [Aggregated()]
            public XPCollection<ProductionProjectDetails> ProjectProduction
            {
                get
                {
                    return GetCollection<ProductionProjectDetails>("ProjectProduction");
                }
            }

            [Association("Project-ProductionSchedule", typeof(ProductionSchedule))]
            [Aggregated()]
            public XPCollection<ProductionSchedule> ProjectProductionSchedule
            {
                get
                {
                    return GetCollection<ProductionSchedule>("ProjectProductionSchedule");
                }
            }

            [PersistentAlias("IsNull(ProjectProduction.Sum(UnitsProduced), 0)")]
            public int UnitsProduced
            {
                get
                {
                    return Convert.ToInt32(EvaluateAlias("UnitsProduced"));
                }
            }

            [PersistentAlias("IsNull(ProjectProductionSchedule.Sum(Quantity), 0)")]
            public int UnitsScheduled
            {
                get
                {
                    return Convert.ToInt32(EvaluateAlias("UnitsScheduled"));
                }
            }

            // used to identify if there's still units needed to produce
            public int UnitsNeeded
            {
                get
                {
                    return Math.Max(UnitsRequested - UnitsProduced, 0);
                }
            }

            // Used to identify if there's still units needed to be scheduled
            public int UnitsNeededToSchedule
            {
                get
                {
                    return Math.Max(UnitsRequested - Math.Max(UnitsProduced, UnitsScheduled), 0);
                }
            }

            [PersistentAlias("ProjectProduction.Sum(BagsProduced)")]
            public int BagsProduced
            {
                get
                {
                    return Convert.ToInt32(EvaluateAlias("BagsProduced"));
                }
            }

            [PersistentAlias("ProjectProduction.Sum(PalletsProduced)")]
            public int PalletsProduced
            {
                get
                {
                    return Convert.ToInt32(EvaluateAlias("PalletsProduced"));
                }
            }

            public double PercentageComplete
            {
                get
                {
                    if (UnitsProduced == 0 || UnitsRequested == 0)
                        return 0;

                    return UnitsProduced / (double)UnitsRequested * 100;
                }
            }

            public double RemainingBalance
            {
                get
                {
                    return UnitsRequested - UnitsProduced;
                }
            }

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
                public OperandProperty Oid
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Oid"));
                    }
                }
                public Project.FieldsClass Project
                {
                    get
                    {
                        return new Project.FieldsClass(GetNestedName("Project"));
                    }
                }
                public OperandProperty CustomerPO
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CustomerPO"));
                    }
                }
                public Items.FieldsClass ProjectItem
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("ProjectItem"));
                    }
                }
                public OperandProperty UnitsRequested
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("UnitsRequested"));
                    }
                }
                public OperandProperty BagsRequested
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("BagsRequested"));
                    }
                }
                public OperandProperty PalletsRequested
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PalletsRequested"));
                    }
                }
                public OperandProperty UnitsProduced
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("UnitsProduced"));
                    }
                }
                public OperandProperty BagsProduced
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("BagsProduced"));
                    }
                }
                public OperandProperty PalletsProduced
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PalletsProduced"));
                    }
                }
                public OperandProperty PercentageComplete
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PercentageComplete"));
                    }
                }
                public OperandProperty AllowOverrun
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("AllowOverrun"));
                    }
                }
                public OperandProperty EstimatedShifts
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("EstimatedShifts"));
                    }
                }
                public OperandProperty UnitsScheduled
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("UnitsScheduled"));
                    }
                }
                public OperandProperty UnitsNeeded
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("UnitsNeeded"));
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
