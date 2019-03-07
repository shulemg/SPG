using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblShipDet")]
        public class ShipDet : XPLiteObject
        {
            private int fShipDetDetID;
            [Key(true)]
            public int ShipDetDetID
            {
                get => fShipDetDetID;
                set => SetPropertyValue<int>("ShipDetDetID", ref fShipDetDetID, value);
            }
            private Shipping fShipDetMainID;
            [Association("Shipping-Details")]
            public Shipping ShipDetMainID
            {
                get => fShipDetMainID;
                set => SetPropertyValue("ShipDetMainID", ref fShipDetMainID, value);
            }
            private Items fShipDetItemID;
            public Items ShipDetItemID
            {
                get => fShipDetItemID;
                set => SetPropertyValue("ShipDetItemID", ref fShipDetItemID, value);
            }
            private string fShipDetLot;
            [Size(150)]
            public string ShipDetLot
            {
                get => fShipDetLot;
                set => SetPropertyValue("ShipDetLot", ref fShipDetLot, value);
            }
            private int fShipDetDetQty;
            public int ShipDetDetQty
            {
                get => fShipDetDetQty;
                set => SetPropertyValue<int>("ShipDetDetQty", ref fShipDetDetQty, value);
            }
            private float fsngPackages;
            public float sngPackages
            {
                get => fsngPackages;
                set => SetPropertyValue("sngPackages", ref fsngPackages, value);
            }
            private float fsngPallets;
            public float sngPallets
            {
                get => fsngPallets;
                set => SetPropertyValue("sngPallets", ref fsngPallets, value);
            }
            private string m_Note;
            [Size(255)]
            public string Note
            {
                get => m_Note;
                set => SetPropertyValue("Note", ref m_Note, value);
            }
            private DateTime fExpirationDate;
            public DateTime ExpirationDate
            {
                get => fExpirationDate;
                set => SetPropertyValue<DateTime>("ExpirationDate", ref fExpirationDate, value);
            }
            private string fFullLPNNumber;
            public string FullLPNNumber
            {
                get => fFullLPNNumber;
                set => SetPropertyValue("FullLPNNumber", ref fFullLPNNumber, value);
            }

            public ShipDet(Session session) : base(session)
            {
            }
            public ShipDet() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }


            private static FieldsClass _Fields;
            public static new FieldsClass Fields
            {
                get
                {
                    if (ReferenceEquals(_Fields, null))
                        _Fields = new FieldsClass();
                    return _Fields;
                }
            }
            // Created/Updated: Joel-PC\Joel on JOEL-PC at 1/27/2013 5:05 PM
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ShipDetDetID => new OperandProperty(GetNestedName("ShipDetDetID"));
                public Shipping.FieldsClass ShipDetMainID => new Shipping.FieldsClass(GetNestedName("ShipDetMainID"));
                public Items.FieldsClass ShipDetItemID => new Items.FieldsClass(GetNestedName("ShipDetItemID"));
                public const string ShipDetLotFieldName = "ShipDetLot";
                public OperandProperty ShipDetLot => new OperandProperty(GetNestedName("ShipDetLot"));
                public OperandProperty ShipDetDetQty => new OperandProperty(GetNestedName("ShipDetDetQty"));
                public OperandProperty sngPackages => new OperandProperty(GetNestedName("sngPackages"));
                public OperandProperty sngPallets => new OperandProperty(GetNestedName("sngPallets"));
                public const string NoteFieldName = "Note";
                public OperandProperty Note => new OperandProperty(GetNestedName("Note"));
                public const string ExpirationDateFieldName = "ExpirationDate";
                public OperandProperty ExpirationDate => new OperandProperty(GetNestedName("ExpirationDate"));
                public const string FullLPNNuvberFieldName = "FullLPNNumber";
                public OperandProperty FullLPNNumber => new OperandProperty(GetNestedName("FullLPNNumber"));
            }
        }
    }
}
