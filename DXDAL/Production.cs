using Microsoft.VisualBasic;
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Text;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblProdMain")]
        public class Production : XPLiteObject
        {
            private int fProdMainID;
            [Key()]
            public int ProdMainID
            {
                get => fProdMainID;
                set => SetPropertyValue<int>("ProdMainID", ref fProdMainID, value);
            }
            private DateTime fProdMainDate;
            public DateTime ProdMainDate
            {
                get => fProdMainDate;
                set => SetPropertyValue<DateTime>("ProdMainDate", ref fProdMainDate, value);
            }
            private Shifts fProdMainShift;
            public Shifts ProdMainShift
            {
                get => fProdMainShift;
                set => SetPropertyValue("ProdMainShift", ref fProdMainShift, value);
            }
            private Items fProdMainItemID;
            public Items ProdMainItemID
            {
                get => fProdMainItemID;
                set => SetPropertyValue("ProdMainItemID", ref fProdMainItemID, value);
            }
            private string fProdMainLot;
            [Size(150)]
            public string ProdMainLot
            {
                get => fProdMainLot;
                set => SetPropertyValue("ProdMainLot", ref fProdMainLot, value);
            }
            private float fProdMainQuantity;
            public float ProdMainQuantity
            {
                get => fProdMainQuantity;
                set => SetPropertyValue("ProdMainQuantity", ref fProdMainQuantity, value);
            }
            private MachineLine fProdMainMachineLine;
            public MachineLine ProdMainMachineLine
            {
                get => fProdMainMachineLine;
                set => SetPropertyValue("ProdMainMachineLine", ref fProdMainMachineLine, value);
            }
            private DateTime fProdMainTimeStart;
            public DateTime ProdMainTimeStart
            {
                get => fProdMainTimeStart;
                set => SetPropertyValue<DateTime>("ProdMainTimeStart", ref fProdMainTimeStart, value);
            }
            private DateTime fProdMainTimeStop;
            public DateTime ProdMainTimeStop
            {
                get => fProdMainTimeStop;
                set => SetPropertyValue<DateTime>("ProdMainTimeStop", ref fProdMainTimeStop, value);
            }
            private float fProdMainPackers;
            public float ProdMainPackers
            {
                get => fProdMainPackers;
                set => SetPropertyValue("ProdMainPackers", ref fProdMainPackers, value);
            }
            private float fProdMainOperators;
            public float ProdMainOperators
            {
                get => fProdMainOperators;
                set => SetPropertyValue("ProdMainOperators", ref fProdMainOperators, value);
            }
            private float fProdMainSupers;
            public float ProdMainSupers
            {
                get => fProdMainSupers;
                set => SetPropertyValue("ProdMainSupers", ref fProdMainSupers, value);
            }
            private int fintMachineSpeed;
            public int intMachineSpeed
            {
                get => fintMachineSpeed;
                set => SetPropertyValue<int>("intMachineSpeed", ref fintMachineSpeed, value);
            }
            private string fstrEnteredBy;
            [Size(50)]
            public string strEnteredBy
            {
                get => fstrEnteredBy;
                set => SetPropertyValue("strEnteredBy", ref fstrEnteredBy, value);
            }
            private DateTime fdtmEnteredOn;
            public DateTime dtmEnteredOn
            {
                get => fdtmEnteredOn;
                set => SetPropertyValue<DateTime>("dtmEnteredOn", ref fdtmEnteredOn, value);
            }
            [Association("Production-Reasons")]
            public XPCollection<ReasonCodes> ReasonCodes => GetCollection<ReasonCodes>("ReasonCodes");
            public string Reasons
            {
                get
                {
                    StringBuilder result = new StringBuilder(string.Empty);

                    foreach (ReasonCodes reason in ReasonCodes)
                    {
                        if (reason.ReasonCode.Length > 0)
                        {
                            if (result.Length < 1)
                                result.Append(reason.ReasonCode);
                            else
                                result.AppendFormat("; {0}", reason.ReasonCode);
                        }
                    }

                    return result.ToString();
                }
            }
            public Production(Session session) : base(session)
            {
            }
            public Production() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }
            // Created/Updated: Joel-PC\Joel on JOEL-PC at 1/27/2013 4:54 PM
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ProdMainID => new OperandProperty(GetNestedName("ProdMainID"));
                public OperandProperty ProdMainDate => new OperandProperty(GetNestedName("ProdMainDate"));
                public Shifts.FieldsClass ProdMainShift => new Shifts.FieldsClass(GetNestedName("ProdMainShift"));
                public Items.FieldsClass ProdMainItemID => new Items.FieldsClass(GetNestedName("ProdMainItemID"));
                public const string ProdMainLotFieldName = "ProdMainLot";
                public OperandProperty ProdMainLot => new OperandProperty(GetNestedName("ProdMainLot"));
                public OperandProperty ProdMainQuantity => new OperandProperty(GetNestedName("ProdMainQuantity"));
                public MachineLine.FieldsClass ProdMainMachineLine => new MachineLine.FieldsClass(GetNestedName("ProdMainMachineLine"));
                public OperandProperty ProdMainTimeStart => new OperandProperty(GetNestedName("ProdMainTimeStart"));
                public OperandProperty ProdMainTimeStop => new OperandProperty(GetNestedName("ProdMainTimeStop"));
                public OperandProperty ProdMainPackers => new OperandProperty(GetNestedName("ProdMainPackers"));
                public OperandProperty ProdMainOperators => new OperandProperty(GetNestedName("ProdMainOperators"));
                public OperandProperty ProdMainSupers => new OperandProperty(GetNestedName("ProdMainSupers"));
                public OperandProperty intMachineSpeed => new OperandProperty(GetNestedName("intMachineSpeed"));
                public const string strEnteredByFieldName = "strEnteredBy";
                public OperandProperty strEnteredBy => new OperandProperty(GetNestedName("strEnteredBy"));
                public OperandProperty dtmEnteredOn => new OperandProperty(GetNestedName("dtmEnteredOn"));
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
