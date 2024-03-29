﻿using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblReceivDet")]
        public class ReceivingDetail : XPLiteObject
        {
            private int fReceivDetID;
            [Key(true)]
            public int ReceivDetID
            {
                get => fReceivDetID;
                set => SetPropertyValue<int>("ReceivDetID", ref fReceivDetID, value);
            }
            private Receiving fReceivMainID;
            [Association("Receiving-Details")]
            public Receiving ReceivMainID
            {
                get => fReceivMainID;
                set => SetPropertyValue("ReceivMainID", ref fReceivMainID, value);
            }
            private Items fReceivDetItemID;
            public Items ReceivDetItemID
            {
                get => fReceivDetItemID;
                set => SetPropertyValue("ReceivDetItemID", ref fReceivDetItemID, value);
            }
            private string fReceivDetLot;
            [Size(150)]
            public string ReceivDetLot
            {
                get => fReceivDetLot;
                set => SetPropertyValue("ReceivDetLot", ref fReceivDetLot, value);
            }
            private int? fReceivDetLPN;
            public int? ReceivDetLPN
            {
                get => fReceivDetLPN;
                set => SetPropertyValue("ReceivDetLPN", ref fReceivDetLPN, value);
            }
            private int fReceivDetQty;
            public int ReceivDetQty
            {
                get => fReceivDetQty;
                set => SetPropertyValue<int>("ReceivDetQty", ref fReceivDetQty, value);
            }
            private int fintUnits;
            public int intUnits
            {
                get => fintUnits;
                set => SetPropertyValue<int>("intUnits", ref fintUnits, value);
            }
            private DateTime? fExpirationDate;
            public DateTime? ExpirationDate
            {
                get => fExpirationDate;
                set => SetPropertyValue("ExpirationDate", ref fExpirationDate, value);
            }

            public ReceivingDetail(Session session) : base(session)
            {
            }
            public ReceivingDetail() : base(Session.DefaultSession)
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
                public OperandProperty ReceivDetID => new OperandProperty(GetNestedName("ReceivDetID"));
                public Receiving.FieldsClass ReceivMainID => new Receiving.FieldsClass(GetNestedName("ReceivMainID"));
                public Items.FieldsClass ReceivDetItemID => new Items.FieldsClass(GetNestedName("ReceivDetItemID"));
                public const string ReceivDetLotFieldName = "ReceivDetLot";
                public OperandProperty ReceivDetLot => new OperandProperty(GetNestedName("ReceivDetLot"));
                public OperandProperty ReceivDetLPN => new OperandProperty(GetNestedName("ReceivDetLPN"));
                public OperandProperty ReceivDetQty => new OperandProperty(GetNestedName("ReceivDetQty"));
                public OperandProperty intUnits => new OperandProperty(GetNestedName("intUnits"));
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
