using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class ProductionProjectDetails : AuditableBase
        {
            private ProjectDetails _ProjectDetail;
            private Inventory _Production;
            private int _unitsProduced;
            private int _bagsProduced;
            private int _palletsProduced;
            private bool _IsOverrun;

            [Association("Production-ProjectDetail")]
            public ProjectDetails ProjectDetail
            {
                get
                {
                    return _ProjectDetail;
                }
                set
                {
                    SetPropertyValue<ProjectDetails>("ProjectDetail", ref _ProjectDetail, value);
                }
            }

            [Association("ProjectDetails-Production")]
            public Inventory Production
            {
                get
                {
                    return _Production;
                }
                set
                {
                    SetPropertyValue<Inventory>("Production", ref _Production, value);
                }
            }

            public int UnitsProduced
            {
                get
                {
                    return _unitsProduced;
                }
                set
                {
                    SetPropertyValue<int>("UnitsProduced", ref _unitsProduced, value);
                }
            }

            public int BagsProduced
            {
                get
                {
                    return _bagsProduced;
                }
                set
                {
                    SetPropertyValue<int>("BagsProduced", ref _bagsProduced, value);
                }
            }

            public int PalletsProduced
            {
                get
                {
                    return _palletsProduced;
                }
                set
                {
                    SetPropertyValue<int>("PalletsProduced", ref _palletsProduced, value);
                }
            }

            public bool IsOverrun
            {
                get
                {
                    return _IsOverrun;
                }
                set
                {
                    SetPropertyValue<bool>("IsOverrun", ref _IsOverrun, value);
                }
            }

            public ProductionProjectDetails() : base()
            {
            }

            public ProductionProjectDetails(Session session) : base(session)
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
                public ProjectDetails.FieldsClass ProjectDetail
                {
                    get
                    {
                        return new ProjectDetails.FieldsClass(GetNestedName("ProjectDetail"));
                    }
                }
                public Inventory.FieldsClass Production
                {
                    get
                    {
                        return new Inventory.FieldsClass(GetNestedName("Production"));
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
                public OperandProperty IsOverrun
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PalletsProduced"));
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
