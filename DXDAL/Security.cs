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
                get => fAdvancedTabs;
                set => SetPropertyValue("AdvancedTabs", ref fAdvancedTabs, value);
            }
            private bool fProductionReport;
            public bool ProductionReport
            {
                get => fProductionReport;
                set => SetPropertyValue("ProductionReport", ref fProductionReport, value);
            }
            private string fstrUser;
            [Key()]
            [Size(50)]
            public string strUser
            {
                get => fstrUser;
                set => SetPropertyValue("strUser", ref fstrUser, value);
            }
            private bool fCostingReport;
            public bool CostingReport
            {
                get => fCostingReport;
                set => SetPropertyValue("CostingReport", ref fCostingReport, value);
            }
            private bool fItemsForm;
            public bool ItemsForm
            {
                get => fItemsForm;
                set => SetPropertyValue("ItemsForm", ref fItemsForm, value);
            }
            private bool fProductionForm;
            public bool ProductionForm
            {
                get => fProductionForm;
                set => SetPropertyValue("ProductionForm", ref fProductionForm, value);
            }
            private bool fCustomersForm;
            public bool CustomersForm
            {
                get => fCustomersForm;
                set => SetPropertyValue("CustomersForm", ref fCustomersForm, value);
            }
            private bool fShippingForm;
            public bool ShippingForm
            {
                get => fShippingForm;
                set => SetPropertyValue("ShippingForm", ref fShippingForm, value);
            }
            private bool fReceivingForm;
            public bool ReceivingForm
            {
                get => fReceivingForm;
                set => SetPropertyValue("ReceivingForm", ref fReceivingForm, value);
            }
            private bool fFinancialTabs;
            public bool FinancialTabs
            {
                get => fFinancialTabs;
                set => SetPropertyValue("FinancialTabs", ref fFinancialTabs, value);
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
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty AdvancedTabs => new OperandProperty(GetNestedName("AdvancedTabs"));
                public OperandProperty ProductionReport => new OperandProperty(GetNestedName("ProductionReport"));
                public OperandProperty strUser => new OperandProperty(GetNestedName("strUser"));
                public OperandProperty CostingReport => new OperandProperty(GetNestedName("CostingReport"));
                public OperandProperty ItemsForm => new OperandProperty(GetNestedName("ItemsForm"));
                public OperandProperty ProductionForm => new OperandProperty(GetNestedName("ProductionForm"));
                public OperandProperty CustomersForm => new OperandProperty(GetNestedName("CustomersForm"));
                public OperandProperty ShippingForm => new OperandProperty(GetNestedName("ShippingForm"));
                public OperandProperty ReceivingForm => new OperandProperty(GetNestedName("ReceivingForm"));
                public OperandProperty FinancialTabs => new OperandProperty(GetNestedName("FinancialTabs"));
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
