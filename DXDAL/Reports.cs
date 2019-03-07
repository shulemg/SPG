using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblReports")]
        public class Reports : XPLiteObject
        {
            private int fReportID;
            [Key(true)]
            public int ReportID
            {
                get => fReportID;
                set => SetPropertyValue<int>("ReportID", ref fReportID, value);
            }
            private string fName;
            [Size(50)]
            public string Name
            {
                get => fName;
                set => SetPropertyValue("Name", ref fName, value);
            }
            private string fCodeName;
            [Size(50)]
            public string CodeName
            {
                get => fCodeName;
                set => SetPropertyValue("CodeName", ref fCodeName, value);
            }
            private string f_Module;
            [Size(50)]
            [Persistent("Module")]
            public string _Module
            {
                get => f_Module;
                set => SetPropertyValue("_Module", ref f_Module, value);
            }
            private string fType;
            [Size(50)]
            public string Type
            {
                get => fType;
                set => SetPropertyValue("Type", ref fType, value);
            }
            private bool fFilterReport;
            public bool FilterReport
            {
                get => fFilterReport;
                set => SetPropertyValue("FilterReport", ref fFilterReport, value);
            }
            private bool fDateFilter;
            public bool DateFilter
            {
                get => fDateFilter;
                set => SetPropertyValue("DateFilter", ref fDateFilter, value);
            }
            private bool fMachineFilter;
            public bool MachineFilter
            {
                get => fMachineFilter;
                set => SetPropertyValue("MachineFilter", ref fMachineFilter, value);
            }
            private bool fShiftFilter;
            public bool ShiftFilter
            {
                get => fShiftFilter;
                set => SetPropertyValue("ShiftFilter", ref fShiftFilter, value);
            }
            private bool fCustomerFilter;
            public bool CustomerFilter
            {
                get => fCustomerFilter;
                set => SetPropertyValue("CustomerFilter", ref fCustomerFilter, value);
            }
            private bool fLotFilter;
            public bool LotFilter
            {
                get => fLotFilter;
                set => SetPropertyValue("LotFilter", ref fLotFilter, value);
            }
            private bool fPOFilter;
            public bool POFilter
            {
                get => fPOFilter;
                set => SetPropertyValue("POFilter", ref fPOFilter, value);
            }
            private bool fItemFilter;
            public bool ItemFilter
            {
                get => fItemFilter;
                set => SetPropertyValue("ItemFilter", ref fItemFilter, value);
            }
            private bool fBOLFilter;
            public bool BOLFilter
            {
                get => fBOLFilter;
                set => SetPropertyValue("BOLFilter", ref fBOLFilter, value);
            }
            private bool fDNFilter;
            public bool DNFilter
            {
                get => fDNFilter;
                set => SetPropertyValue("DNFilter", ref fDNFilter, value);
            }
            private bool fDestinationFilter;
            public bool DestinationFilter
            {
                get => fDestinationFilter;
                set => SetPropertyValue("DestinationFilter", ref fDestinationFilter, value);
            }
            private bool fCarrierFilter;
            public bool CarrierFilter
            {
                get => fCarrierFilter;
                set => SetPropertyValue("CarrierFilter", ref fCarrierFilter, value);
            }
            private bool fVendorFilter;
            public bool VendorFilter
            {
                get => fVendorFilter;
                set => SetPropertyValue("VendorFilter", ref fVendorFilter, value);
            }
            private bool fitemtypeFilter;
            public bool itemtypeFilter
            {
                get => fitemtypeFilter;
                set => SetPropertyValue("itemtypeFilter", ref fitemtypeFilter, value);
            }
            public Reports(Session session) : base(session)
            {
            }
            public Reports() : base(Session.DefaultSession)
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
                public OperandProperty ReportID => new OperandProperty(GetNestedName("ReportID"));
                public OperandProperty Name => new OperandProperty(GetNestedName("Name"));
                public OperandProperty CodeName => new OperandProperty(GetNestedName("CodeName"));
                public OperandProperty _Module => new OperandProperty(GetNestedName("_Module"));
                public OperandProperty Type => new OperandProperty(GetNestedName("Type"));
                public OperandProperty FilterReport => new OperandProperty(GetNestedName("FilterReport"));
                public OperandProperty DateFilter => new OperandProperty(GetNestedName("DateFilter"));
                public OperandProperty MachineFilter => new OperandProperty(GetNestedName("MachineFilter"));
                public OperandProperty ShiftFilter => new OperandProperty(GetNestedName("ShiftFilter"));
                public OperandProperty CustomerFilter => new OperandProperty(GetNestedName("CustomerFilter"));
                public OperandProperty LotFilter => new OperandProperty(GetNestedName("LotFilter"));
                public OperandProperty POFilter => new OperandProperty(GetNestedName("POFilter"));
                public OperandProperty ItemFilter => new OperandProperty(GetNestedName("ItemFilter"));
                public OperandProperty BOLFilter => new OperandProperty(GetNestedName("BOLFilter"));
                public OperandProperty DNFilter => new OperandProperty(GetNestedName("DNFilter"));
                public OperandProperty DestinationFilter => new OperandProperty(GetNestedName("DestinationFilter"));
                public OperandProperty CarrierFilter => new OperandProperty(GetNestedName("CarrierFilter"));
                public OperandProperty VendorFilter => new OperandProperty(GetNestedName("VendorFilter"));
                public OperandProperty itemtypeFilter => new OperandProperty(GetNestedName("itemtypeFilter"));
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
