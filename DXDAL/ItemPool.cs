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
                get
                {
                    return _poolCode;
                }
                set
                {
                    SetPropertyValue<string>("PoolCode", ref _poolCode, value);
                }
            }

            [Size(1073741823)]
            public string PoolDescription
            {
                get
                {
                    return _poolDescription;
                }
                set
                {
                    SetPropertyValue<string>("PoolDescription", ref _poolDescription, value);
                }
            }

            [Size(50)]
            public string PoolType
            {
                get
                {
                    return _poolType;
                }
                set
                {
                    SetPropertyValue<string>("PoolType", ref _poolType, value);
                }
            }

            public Customers PoolCustomerID
            {
                get
                {
                    return _poolCustomerID;
                }
                set
                {
                    SetPropertyValue<Customers>("PoolCustomerID", ref _poolCustomerID, value);
                }
            }

            [Association("ItemPool-Details", typeof(ItemPoolDetails))]
            [Aggregated()]
            public XPCollection<ItemPoolDetails> Details
            {
                get
                {
                    return GetCollection<ItemPoolDetails>("Details");
                }
            }

            [PersistentAlias("Details.Sum(QuantityOnHand)")]
            public double QuantityOnHand
            {
                get
                {
                    return Convert.ToDouble(EvaluateAlias("QuantityOnHand"));
                }
            }

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

            public new class FieldsClass : DevExpress.Xpo.PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty PoolCode
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PoolCode"));
                    }
                }
                public OperandProperty PoolDescription
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PoolDescription"));
                    }
                }
                public OperandProperty PoolType
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PoolType"));
                    }
                }
                public Customers.FieldsClass PoolCustomerID
                {
                    get
                    {
                        return new Customers.FieldsClass(GetNestedName("PoolCustomerID"));
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
