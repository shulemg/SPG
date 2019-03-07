using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class ItemPool : AuditableBase
        {

            // Fields...
            private string _poolType;
            private string _poolDescription;
            private string _poolCode;
            private Customers _poolCustomerID;
            [Size(50)]
            public string PoolCode
            {
                get => _poolCode;
                set => SetPropertyValue("PoolCode", ref _poolCode, value);
            }

            [Size(1073741823)]
            public string PoolDescription
            {
                get => _poolDescription;
                set => SetPropertyValue("PoolDescription", ref _poolDescription, value);
            }

            [Size(50)]
            public string PoolType
            {
                get => _poolType;
                set => SetPropertyValue("PoolType", ref _poolType, value);
            }

            public Customers PoolCustomerID
            {
                get => _poolCustomerID;
                set => SetPropertyValue("PoolCustomerID", ref _poolCustomerID, value);
            }

            [Association("ItemPool-Details", typeof(ItemPoolDetails))]
            [Aggregated()]
            public XPCollection<ItemPoolDetails> Details => GetCollection<ItemPoolDetails>("Details");

            [PersistentAlias("Details.Sum(QuantityOnHand)")]
            public double QuantityOnHand => Convert.ToDouble(EvaluateAlias("QuantityOnHand"));

            public ItemPool() : base()
            {
            }

            public ItemPool(Session session) : base(session)
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
                public OperandProperty PoolCode => new OperandProperty(GetNestedName("PoolCode"));
                public OperandProperty PoolDescription => new OperandProperty(GetNestedName("PoolDescription"));
                public OperandProperty PoolType => new OperandProperty(GetNestedName("PoolType"));
                public Customers.FieldsClass PoolCustomerID => new Customers.FieldsClass(GetNestedName("PoolCustomerID"));
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
