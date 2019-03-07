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
                get => _ProjectDetail;
                set => SetPropertyValue("ProjectDetail", ref _ProjectDetail, value);
            }

            [Association("ProjectDetails-Production")]
            public Inventory Production
            {
                get => _Production;
                set => SetPropertyValue("Production", ref _Production, value);
            }

            public int UnitsProduced
            {
                get => _unitsProduced;
                set => SetPropertyValue<int>("UnitsProduced", ref _unitsProduced, value);
            }

            public int BagsProduced
            {
                get => _bagsProduced;
                set => SetPropertyValue<int>("BagsProduced", ref _bagsProduced, value);
            }

            public int PalletsProduced
            {
                get => _palletsProduced;
                set => SetPropertyValue<int>("PalletsProduced", ref _palletsProduced, value);
            }

            public bool IsOverrun
            {
                get => _IsOverrun;
                set => SetPropertyValue("IsOverrun", ref _IsOverrun, value);
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

            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty Oid => new OperandProperty(GetNestedName("Oid"));
                public ProjectDetails.FieldsClass ProjectDetail => new ProjectDetails.FieldsClass(GetNestedName("ProjectDetail"));
                public Inventory.FieldsClass Production => new Inventory.FieldsClass(GetNestedName("Production"));
                public OperandProperty UnitsProduced => new OperandProperty(GetNestedName("UnitsProduced"));
                public OperandProperty BagsProduced => new OperandProperty(GetNestedName("BagsProduced"));
                public OperandProperty PalletsProduced => new OperandProperty(GetNestedName("PalletsProduced"));
                public OperandProperty IsOverrun => new OperandProperty(GetNestedName("PalletsProduced"));
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
