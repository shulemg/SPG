using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblSecurity")]
        public class Security : XPLiteObject
        {
            private bool fAdvancedTabs;
            public bool AdvancedTabs
            {
                get
                {
                    return fAdvancedTabs;
                }
                set
                {
                    SetPropertyValue<bool>("AdvancedTabs", ref fAdvancedTabs, value);
                }
            }
            private bool fProductionReport;
            public bool ProductionReport
            {
                get
                {
                    return fProductionReport;
                }
                set
                {
                    SetPropertyValue<bool>("ProductionReport", ref fProductionReport, value);
                }
            }
            private string fstrUser;
            [Key()]
            [Size(50)]
            public string strUser
            {
                get
                {
                    return fstrUser;
                }
                set
                {
                    SetPropertyValue<string>("strUser", ref fstrUser, value);
                }
            }
            private bool fCostingReport;
            public bool CostingReport
            {
                get
                {
                    return fCostingReport;
                }
                set
                {
                    SetPropertyValue<bool>("CostingReport", ref fCostingReport, value);
                }
            }
            private bool fItemsForm;
            public bool ItemsForm
            {
                get
                {
                    return fItemsForm;
                }
                set
                {
                    SetPropertyValue<bool>("ItemsForm", ref fItemsForm, value);
                }
            }
            private bool fProductionForm;
            public bool ProductionForm
            {
                get
                {
                    return fProductionForm;
                }
                set
                {
                    SetPropertyValue<bool>("ProductionForm", ref fProductionForm, value);
                }
            }
            private bool fCustomersForm;
            public bool CustomersForm
            {
                get
                {
                    return fCustomersForm;
                }
                set
                {
                    SetPropertyValue<bool>("CustomersForm", ref fCustomersForm, value);
                }
            }
            private bool fShippingForm;
            public bool ShippingForm
            {
                get
                {
                    return fShippingForm;
                }
                set
                {
                    SetPropertyValue<bool>("ShippingForm", ref fShippingForm, value);
                }
            }
            private bool fReceivingForm;
            public bool ReceivingForm
            {
                get
                {
                    return fReceivingForm;
                }
                set
                {
                    SetPropertyValue<bool>("ReceivingForm", ref fReceivingForm, value);
                }
            }
            private bool fFinancialTabs;
            public bool FinancialTabs
            {
                get
                {
                    return fFinancialTabs;
                }
                set
                {
                    SetPropertyValue<bool>("FinancialTabs", ref fFinancialTabs, value);
                }
            }
            public Security(Session session) : base(session)
            {
            }
            public Security() : base(Session.DefaultSession)
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
                public OperandProperty AdvancedTabs
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("AdvancedTabs"));
                    }
                }
                public OperandProperty ProductionReport
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ProductionReport"));
                    }
                }
                public OperandProperty strUser
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strUser"));
                    }
                }
                public OperandProperty CostingReport
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CostingReport"));
                    }
                }
                public OperandProperty ItemsForm
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ItemsForm"));
                    }
                }
                public OperandProperty ProductionForm
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ProductionForm"));
                    }
                }
                public OperandProperty CustomersForm
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CustomersForm"));
                    }
                }
                public OperandProperty ShippingForm
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShippingForm"));
                    }
                }
                public OperandProperty ReceivingForm
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ReceivingForm"));
                    }
                }
                public OperandProperty FinancialTabs
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("FinancialTabs"));
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
