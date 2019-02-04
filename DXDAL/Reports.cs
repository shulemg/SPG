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
                get
                {
                    return fReportID;
                }
                set
                {
                    SetPropertyValue<int>("ReportID", ref fReportID, value);
                }
            }
            private string fName;
            [Size(50)]
            public string Name
            {
                get
                {
                    return fName;
                }
                set
                {
                    SetPropertyValue<string>("Name", ref fName, value);
                }
            }
            private string fCodeName;
            [Size(50)]
            public string CodeName
            {
                get
                {
                    return fCodeName;
                }
                set
                {
                    SetPropertyValue<string>("CodeName", ref fCodeName, value);
                }
            }
            private string f_Module;
            [Size(50)]
            [Persistent("Module")]
            public string _Module
            {
                get
                {
                    return f_Module;
                }
                set
                {
                    SetPropertyValue<string>("_Module", ref f_Module, value);
                }
            }
            private string fType;
            [Size(50)]
            public string Type
            {
                get
                {
                    return fType;
                }
                set
                {
                    SetPropertyValue<string>("Type", ref fType, value);
                }
            }
            private bool fFilterReport;
            public bool FilterReport
            {
                get
                {
                    return fFilterReport;
                }
                set
                {
                    SetPropertyValue<bool>("FilterReport", ref fFilterReport, value);
                }
            }
            private bool fDateFilter;
            public bool DateFilter
            {
                get
                {
                    return fDateFilter;
                }
                set
                {
                    SetPropertyValue<bool>("DateFilter", ref fDateFilter, value);
                }
            }
            private bool fMachineFilter;
            public bool MachineFilter
            {
                get
                {
                    return fMachineFilter;
                }
                set
                {
                    SetPropertyValue<bool>("MachineFilter", ref fMachineFilter, value);
                }
            }
            private bool fShiftFilter;
            public bool ShiftFilter
            {
                get
                {
                    return fShiftFilter;
                }
                set
                {
                    SetPropertyValue<bool>("ShiftFilter", ref fShiftFilter, value);
                }
            }
            private bool fCustomerFilter;
            public bool CustomerFilter
            {
                get
                {
                    return fCustomerFilter;
                }
                set
                {
                    SetPropertyValue<bool>("CustomerFilter", ref fCustomerFilter, value);
                }
            }
            private bool fLotFilter;
            public bool LotFilter
            {
                get
                {
                    return fLotFilter;
                }
                set
                {
                    SetPropertyValue<bool>("LotFilter", ref fLotFilter, value);
                }
            }
            private bool fPOFilter;
            public bool POFilter
            {
                get
                {
                    return fPOFilter;
                }
                set
                {
                    SetPropertyValue<bool>("POFilter", ref fPOFilter, value);
                }
            }
            private bool fItemFilter;
            public bool ItemFilter
            {
                get
                {
                    return fItemFilter;
                }
                set
                {
                    SetPropertyValue<bool>("ItemFilter", ref fItemFilter, value);
                }
            }
            private bool fBOLFilter;
            public bool BOLFilter
            {
                get
                {
                    return fBOLFilter;
                }
                set
                {
                    SetPropertyValue<bool>("BOLFilter", ref fBOLFilter, value);
                }
            }
            private bool fDNFilter;
            public bool DNFilter
            {
                get
                {
                    return fDNFilter;
                }
                set
                {
                    SetPropertyValue<bool>("DNFilter", ref fDNFilter, value);
                }
            }
            private bool fDestinationFilter;
            public bool DestinationFilter
            {
                get
                {
                    return fDestinationFilter;
                }
                set
                {
                    SetPropertyValue<bool>("DestinationFilter", ref fDestinationFilter, value);
                }
            }
            private bool fCarrierFilter;
            public bool CarrierFilter
            {
                get
                {
                    return fCarrierFilter;
                }
                set
                {
                    SetPropertyValue<bool>("CarrierFilter", ref fCarrierFilter, value);
                }
            }
            private bool fVendorFilter;
            public bool VendorFilter
            {
                get
                {
                    return fVendorFilter;
                }
                set
                {
                    SetPropertyValue<bool>("VendorFilter", ref fVendorFilter, value);
                }
            }
            private bool fitemtypeFilter;
            public bool itemtypeFilter
            {
                get
                {
                    return fitemtypeFilter;
                }
                set
                {
                    SetPropertyValue<bool>("itemtypeFilter", ref fitemtypeFilter, value);
                }
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
            public new class FieldsClass : DevExpress.Xpo.PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ReportID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ReportID"));
                    }
                }
                public OperandProperty Name
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Name"));
                    }
                }
                public OperandProperty CodeName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CodeName"));
                    }
                }
                public OperandProperty _Module
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("_Module"));
                    }
                }
                public OperandProperty Type
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Type"));
                    }
                }
                public OperandProperty FilterReport
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("FilterReport"));
                    }
                }
                public OperandProperty DateFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("DateFilter"));
                    }
                }
                public OperandProperty MachineFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("MachineFilter"));
                    }
                }
                public OperandProperty ShiftFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShiftFilter"));
                    }
                }
                public OperandProperty CustomerFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CustomerFilter"));
                    }
                }
                public OperandProperty LotFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LotFilter"));
                    }
                }
                public OperandProperty POFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("POFilter"));
                    }
                }
                public OperandProperty ItemFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ItemFilter"));
                    }
                }
                public OperandProperty BOLFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("BOLFilter"));
                    }
                }
                public OperandProperty DNFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("DNFilter"));
                    }
                }
                public OperandProperty DestinationFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("DestinationFilter"));
                    }
                }
                public OperandProperty CarrierFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CarrierFilter"));
                    }
                }
                public OperandProperty VendorFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("VendorFilter"));
                    }
                }
                public OperandProperty itemtypeFilter
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("itemtypeFilter"));
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
