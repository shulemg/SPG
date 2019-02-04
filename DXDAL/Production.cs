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
                get
                {
                    return fProdMainID;
                }
                set
                {
                    SetPropertyValue<int>("ProdMainID", ref fProdMainID, value);
                }
            }
            private DateTime fProdMainDate;
            public DateTime ProdMainDate
            {
                get
                {
                    return fProdMainDate;
                }
                set
                {
                    SetPropertyValue<DateTime>("ProdMainDate", ref fProdMainDate, value);
                }
            }
            private Shifts fProdMainShift;
            public Shifts ProdMainShift
            {
                get
                {
                    return fProdMainShift;
                }
                set
                {
                    SetPropertyValue<Shifts>("ProdMainShift", ref fProdMainShift, value);
                }
            }
            private Items fProdMainItemID;
            public Items ProdMainItemID
            {
                get
                {
                    return fProdMainItemID;
                }
                set
                {
                    SetPropertyValue<Items>("ProdMainItemID", ref fProdMainItemID, value);
                }
            }
            private string fProdMainLot;
            [Size(150)]
            public string ProdMainLot
            {
                get
                {
                    return fProdMainLot;
                }
                set
                {
                    SetPropertyValue<string>("ProdMainLot", ref fProdMainLot, value);
                }
            }
            private float fProdMainQuantity;
            public float ProdMainQuantity
            {
                get
                {
                    return fProdMainQuantity;
                }
                set
                {
                    SetPropertyValue<float>("ProdMainQuantity", ref fProdMainQuantity, value);
                }
            }
            private MachineLine fProdMainMachineLine;
            public MachineLine ProdMainMachineLine
            {
                get
                {
                    return fProdMainMachineLine;
                }
                set
                {
                    SetPropertyValue<MachineLine>("ProdMainMachineLine", ref fProdMainMachineLine, value);
                }
            }
            private DateTime fProdMainTimeStart;
            public DateTime ProdMainTimeStart
            {
                get
                {
                    return fProdMainTimeStart;
                }
                set
                {
                    SetPropertyValue<DateTime>("ProdMainTimeStart", ref fProdMainTimeStart, value);
                }
            }
            private DateTime fProdMainTimeStop;
            public DateTime ProdMainTimeStop
            {
                get
                {
                    return fProdMainTimeStop;
                }
                set
                {
                    SetPropertyValue<DateTime>("ProdMainTimeStop", ref fProdMainTimeStop, value);
                }
            }
            private float fProdMainPackers;
            public float ProdMainPackers
            {
                get
                {
                    return fProdMainPackers;
                }
                set
                {
                    SetPropertyValue<float>("ProdMainPackers", ref fProdMainPackers, value);
                }
            }
            private float fProdMainOperators;
            public float ProdMainOperators
            {
                get
                {
                    return fProdMainOperators;
                }
                set
                {
                    SetPropertyValue<float>("ProdMainOperators", ref fProdMainOperators, value);
                }
            }
            private float fProdMainSupers;
            public float ProdMainSupers
            {
                get
                {
                    return fProdMainSupers;
                }
                set
                {
                    SetPropertyValue<float>("ProdMainSupers", ref fProdMainSupers, value);
                }
            }
            private int fintMachineSpeed;
            public int intMachineSpeed
            {
                get
                {
                    return fintMachineSpeed;
                }
                set
                {
                    SetPropertyValue<int>("intMachineSpeed", ref fintMachineSpeed, value);
                }
            }
            private string fstrEnteredBy;
            [Size(50)]
            public string strEnteredBy
            {
                get
                {
                    return fstrEnteredBy;
                }
                set
                {
                    SetPropertyValue<string>("strEnteredBy", ref fstrEnteredBy, value);
                }
            }
            private DateTime fdtmEnteredOn;
            public DateTime dtmEnteredOn
            {
                get
                {
                    return fdtmEnteredOn;
                }
                set
                {
                    SetPropertyValue<DateTime>("dtmEnteredOn", ref fdtmEnteredOn, value);
                }
            }
            [Association("Production-Reasons")]
            public XPCollection<ReasonCodes> ReasonCodes
            {
                get
                {
                    return GetCollection<ReasonCodes>("ReasonCodes");
                }
            }
            public string Reasons
            {
                get
                {
                    StringBuilder result = new StringBuilder(string.Empty);

                    foreach (var reason in ReasonCodes)
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
            public new class FieldsClass : XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ProdMainID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ProdMainID"));
                    }
                }
                public OperandProperty ProdMainDate
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ProdMainDate"));
                    }
                }
                public Shifts.FieldsClass ProdMainShift
                {
                    get
                    {
                        return new Shifts.FieldsClass(GetNestedName("ProdMainShift"));
                    }
                }
                public Items.FieldsClass ProdMainItemID
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("ProdMainItemID"));
                    }
                }
                public const string ProdMainLotFieldName = "ProdMainLot";
                public DevExpress.Data.Filtering.OperandProperty ProdMainLot
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ProdMainLot"));
                    }
                }
                public OperandProperty ProdMainQuantity
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ProdMainQuantity"));
                    }
                }
                public MachineLine.FieldsClass ProdMainMachineLine
                {
                    get
                    {
                        return new MachineLine.FieldsClass(GetNestedName("ProdMainMachineLine"));
                    }
                }
                public OperandProperty ProdMainTimeStart
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ProdMainTimeStart"));
                    }
                }
                public OperandProperty ProdMainTimeStop
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ProdMainTimeStop"));
                    }
                }
                public OperandProperty ProdMainPackers
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ProdMainPackers"));
                    }
                }
                public OperandProperty ProdMainOperators
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ProdMainOperators"));
                    }
                }
                public OperandProperty ProdMainSupers
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ProdMainSupers"));
                    }
                }
                public OperandProperty intMachineSpeed
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("intMachineSpeed"));
                    }
                }
                public const string strEnteredByFieldName = "strEnteredBy";
                public DevExpress.Data.Filtering.OperandProperty strEnteredBy
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("strEnteredBy"));
                    }
                }
                public OperandProperty dtmEnteredOn
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dtmEnteredOn"));
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
