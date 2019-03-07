using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblReturnDet")]
        public class ReceivedReturns : XPLiteObject
        {
            private int fReturnDetID;
            [Key(true)]
            public int ReturnDetID
            {
                get => fReturnDetID;
                set => SetPropertyValue<int>("ReturnDetID", ref fReturnDetID, value);
            }
            private Receiving fReceiveMainID;
            [Association("Receiving-Returns")]
            public Receiving ReceiveMainID
            {
                get => fReceiveMainID;
                set => SetPropertyValue("ReceiveMainID", ref fReceiveMainID, value);
            }
            private Items fReturnDetItemID;
            public Items ReturnDetItemID
            {
                get => fReturnDetItemID;
                set => SetPropertyValue("ReturnDetItemID", ref fReturnDetItemID, value);
            }
            private string fReturnDetLot;
            [Size(150)]
            public string ReturnDetLot
            {
                get => fReturnDetLot;
                set => SetPropertyValue("ReturnDetLot", ref fReturnDetLot, value);
            }
            private int fReturnDetQty;
            public int ReturnDetQty
            {
                get => fReturnDetQty;
                set => SetPropertyValue<int>("ReturnDetQty", ref fReturnDetQty, value);
            }
            private int fintUnits;
            public int intUnits
            {
                get => fintUnits;
                set => SetPropertyValue<int>("intUnits", ref fintUnits, value);
            }
            private float fsngPallets;
            public float sngPallets
            {
                get => fsngPallets;
                set => SetPropertyValue("sngPallets", ref fsngPallets, value);
            }
            private string fReason;
            [Size(255)]
            public string Reason
            {
                get => fReason;
                set => SetPropertyValue("Reason", ref fReason, value);
            }
            private DateTime fExpirationDate;
            public DateTime ExpirationDate
            {
                get => fExpirationDate;
                set => SetPropertyValue<DateTime>("ExpirationDate", ref fExpirationDate, value);
            }
            public ReceivedReturns(Session session) : base(session)
            {
            }
            public ReceivedReturns() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }


            // Created/Updated: Joel-PC\Joel on JOEL-PC at 1/27/2013 4:56 PM
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ReturnDetID => new OperandProperty(GetNestedName("ReturnDetID"));
                public Receiving.FieldsClass ReceiveMainID => new Receiving.FieldsClass(GetNestedName("ReceiveMainID"));
                public Items.FieldsClass ReturnDetItemID => new Items.FieldsClass(GetNestedName("ReturnDetItemID"));
                public const string ReturnDetLotFieldName = "ReturnDetLot";
                public OperandProperty ReturnDetLot => new OperandProperty(GetNestedName("ReturnDetLot"));
                public OperandProperty ReturnDetQty => new OperandProperty(GetNestedName("ReturnDetQty"));
                public OperandProperty intUnits => new OperandProperty(GetNestedName("intUnits"));
                public OperandProperty sngPallets => new OperandProperty(GetNestedName("sngPallets"));
                public const string ReasonFieldName = "Reason";
                public OperandProperty Reason => new OperandProperty(GetNestedName("Reason"));
                public const string ExpirationDateFieldName = "ExpirationDate";
                public OperandProperty ExpirationDate => new OperandProperty(GetNestedName("ExpirationDate"));
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
