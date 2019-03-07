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
                get => fPK_ID;
                set => SetPropertyValue<int>("PK_ID", ref fPK_ID, value);
            }
            private float fdblPackersPay;
            public float dblPackersPay
            {
                get => fdblPackersPay;
                set => SetPropertyValue("dblPackersPay", ref fdblPackersPay, value);
            }
            private float fdblOperatorsPay;
            public float dblOperatorsPay
            {
                get => fdblOperatorsPay;
                set => SetPropertyValue("dblOperatorsPay", ref fdblOperatorsPay, value);
            }
            private float fdblSupersPay;
            public float dblSupersPay
            {
                get => fdblSupersPay;
                set => SetPropertyValue("dblSupersPay", ref fdblSupersPay, value);
            }
            private short fintMinPerHour;
            public short intMinPerHour
            {
                get => fintMinPerHour;
                set => SetPropertyValue("intMinPerHour", ref fintMinPerHour, value);
            }
            private int fUniversalCustomer;
            public int UniversalCustomer
            {
                get => fUniversalCustomer;
                set => SetPropertyValue<int>("UniversalCustomer", ref fUniversalCustomer, value);
            }
            private string fdbVersion;
            [Size(50)]
            public string dbVersion
            {
                get => fdbVersion;
                set => SetPropertyValue("dbVersion", ref fdbVersion, value);
            }

            public string LPNPrinterName
            {
                get => _lPNPrinterName;
                set => SetPropertyValue("LPNPrinterName", ref _lPNPrinterName, value);
            }

            public byte LPNHorizontalAdjustment
            {
                get => _lPNRightAdjustment;
                set => SetPropertyValue("LPNHorizontalAdjustment", ref _lPNRightAdjustment, value);
            }

            public byte LPNVerticalAdjustment
            {
                get => _lPNVerticalAdjustment;
                set => SetPropertyValue("LPNVerticalAdjustment", ref _lPNVerticalAdjustment, value);
            }

            public byte LPNPrintCopies
            {
                get => _lPNPrintCopies;
                set => SetPropertyValue("LPNPrintCopies", ref _lPNPrintCopies, value);
            }

            public Locations DefaultLocation
            {
                get => _defaultLocation;
                set => SetPropertyValue("DefaultLocation", ref _defaultLocation, value);
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
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty PK_ID => new OperandProperty(GetNestedName("PK_ID"));
                public OperandProperty dblPackersPay => new OperandProperty(GetNestedName("dblPackersPay"));
                public OperandProperty dblOperatorsPay => new OperandProperty(GetNestedName("dblOperatorsPay"));
                public OperandProperty dblSupersPay => new OperandProperty(GetNestedName("dblSupersPay"));
                public OperandProperty intMinPerHour => new OperandProperty(GetNestedName("intMinPerHour"));
                public OperandProperty UniversalCustomer => new OperandProperty(GetNestedName("UniversalCustomer"));
                public const string dbVersionFieldName = "dbVersion";
                public OperandProperty dbVersion => new OperandProperty(GetNestedName("dbVersion"));
                public const string LPNPrinterNameFieldName = "LPNPrinterName";
                public OperandProperty LPNPrinterName => new OperandProperty(GetNestedName("LPNPrinterName"));
                public OperandProperty LPNHorizontalAdjustment => new OperandProperty(GetNestedName("LPNHorizontalAdjustment"));
                public OperandProperty LPNVerticalAdjustment => new OperandProperty(GetNestedName("LPNVerticalAdjustment"));
                public OperandProperty LPNPrintCopies => new OperandProperty(GetNestedName("LPNPrintCopies"));
                public Locations.FieldsClass DefaultLocation => new Locations.FieldsClass(GetNestedName("DefaultLocation"));
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
