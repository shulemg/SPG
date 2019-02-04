using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblCompanySettings")]
        public class CompanySettings : XPLiteObject
        {
            private byte _lPNPrintCopies = 2;
            private byte _lPNVerticalAdjustment = 0;
            private byte _lPNRightAdjustment = 0;
            private string _lPNPrinterName;
            private Locations _defaultLocation;

            private int fPK_ID;
            [Key(true)]
            public int PK_ID
            {
                get
                {
                    return fPK_ID;
                }
                set
                {
                    SetPropertyValue<int>("PK_ID", ref fPK_ID, value);
                }
            }
            private float fdblPackersPay;
            public float dblPackersPay
            {
                get
                {
                    return fdblPackersPay;
                }
                set
                {
                    SetPropertyValue<float>("dblPackersPay", ref fdblPackersPay, value);
                }
            }
            private float fdblOperatorsPay;
            public float dblOperatorsPay
            {
                get
                {
                    return fdblOperatorsPay;
                }
                set
                {
                    SetPropertyValue<float>("dblOperatorsPay", ref fdblOperatorsPay, value);
                }
            }
            private float fdblSupersPay;
            public float dblSupersPay
            {
                get
                {
                    return fdblSupersPay;
                }
                set
                {
                    SetPropertyValue<float>("dblSupersPay", ref fdblSupersPay, value);
                }
            }
            private short fintMinPerHour;
            public short intMinPerHour
            {
                get
                {
                    return fintMinPerHour;
                }
                set
                {
                    SetPropertyValue<short>("intMinPerHour", ref fintMinPerHour, value);
                }
            }
            private int fUniversalCustomer;
            public int UniversalCustomer
            {
                get
                {
                    return fUniversalCustomer;
                }
                set
                {
                    SetPropertyValue<int>("UniversalCustomer", ref fUniversalCustomer, value);
                }
            }
            private string fdbVersion;
            [Size(50)]
            public string dbVersion
            {
                get
                {
                    return fdbVersion;
                }
                set
                {
                    SetPropertyValue<string>("dbVersion", ref fdbVersion, value);
                }
            }

            public string LPNPrinterName
            {
                get
                {
                    return _lPNPrinterName;
                }
                set
                {
                    SetPropertyValue<string>("LPNPrinterName", ref _lPNPrinterName, value);
                }
            }

            public byte LPNHorizontalAdjustment
            {
                get
                {
                    return _lPNRightAdjustment;
                }
                set
                {
                    SetPropertyValue<byte>("LPNHorizontalAdjustment", ref _lPNRightAdjustment, value);
                }
            }

            public byte LPNVerticalAdjustment
            {
                get
                {
                    return _lPNVerticalAdjustment;
                }
                set
                {
                    SetPropertyValue<byte>("LPNVerticalAdjustment", ref _lPNVerticalAdjustment, value);
                }
            }

            public byte LPNPrintCopies
            {
                get
                {
                    return _lPNPrintCopies;
                }
                set
                {
                    SetPropertyValue<byte>("LPNPrintCopies", ref _lPNPrintCopies, value);
                }
            }

            public Locations DefaultLocation
            {
                get
                {
                    return _defaultLocation;
                }
                set
                {
                    SetPropertyValue<Locations>("DefaultLocation", ref _defaultLocation, value);
                }
            }

            public CompanySettings(Session session) : base(session)
            {
            }
            public CompanySettings() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }
            // Created/Updated: Joel-PC\Joel on JOEL-PC at 3/3/2013 5:48 PM
            public new class FieldsClass : XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty PK_ID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PK_ID"));
                    }
                }
                public OperandProperty dblPackersPay
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblPackersPay"));
                    }
                }
                public OperandProperty dblOperatorsPay
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblOperatorsPay"));
                    }
                }
                public OperandProperty dblSupersPay
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dblSupersPay"));
                    }
                }
                public OperandProperty intMinPerHour
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("intMinPerHour"));
                    }
                }
                public OperandProperty UniversalCustomer
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("UniversalCustomer"));
                    }
                }
                public const string dbVersionFieldName = "dbVersion";
                public DevExpress.Data.Filtering.OperandProperty dbVersion
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("dbVersion"));
                    }
                }
                public const string LPNPrinterNameFieldName = "LPNPrinterName";
                public DevExpress.Data.Filtering.OperandProperty LPNPrinterName
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("LPNPrinterName"));
                    }
                }
                public OperandProperty LPNHorizontalAdjustment
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LPNHorizontalAdjustment"));
                    }
                }
                public OperandProperty LPNVerticalAdjustment
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LPNVerticalAdjustment"));
                    }
                }
                public OperandProperty LPNPrintCopies
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LPNPrintCopies"));
                    }
                }
                public Locations.FieldsClass DefaultLocation
                {
                    get
                    {
                        return new Locations.FieldsClass(GetNestedName("DefaultLocation"));
                    }
                }
            }
            public static new FieldsClass Fields
            {
                get
                {
                    if (ReferenceEquals(_Fields, null))
                        _Fields = new FieldsClass();
                    return _Fields;
                }
            }
            private static FieldsClass _Fields;
        }
    }
}
