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
                get
                {
                    return fShipDetDetID;
                }
                set
                {
                    SetPropertyValue<int>("ShipDetDetID", ref fShipDetDetID, value);
                }
            }
            private Shipping fShipDetMainID;
            [Association("Shipping-Details")]
            public Shipping ShipDetMainID
            {
                get
                {
                    return fShipDetMainID;
                }
                set
                {
                    SetPropertyValue<Shipping>("ShipDetMainID", ref fShipDetMainID, value);
                }
            }
            private Items fShipDetItemID;
            public Items ShipDetItemID
            {
                get
                {
                    return fShipDetItemID;
                }
                set
                {
                    SetPropertyValue<Items>("ShipDetItemID", ref fShipDetItemID, value);
                }
            }
            private string fShipDetLot;
            [Size(150)]
            public string ShipDetLot
            {
                get
                {
                    return fShipDetLot;
                }
                set
                {
                    SetPropertyValue<string>("ShipDetLot", ref fShipDetLot, value);
                }
            }
            private int fShipDetDetQty;
            public int ShipDetDetQty
            {
                get
                {
                    return fShipDetDetQty;
                }
                set
                {
                    SetPropertyValue<int>("ShipDetDetQty", ref fShipDetDetQty, value);
                }
            }
            private float fsngPackages;
            public float sngPackages
            {
                get
                {
                    return fsngPackages;
                }
                set
                {
                    SetPropertyValue<float>("sngPackages", ref fsngPackages, value);
                }
            }
            private float fsngPallets;
            public float sngPallets
            {
                get
                {
                    return fsngPallets;
                }
                set
                {
                    SetPropertyValue<float>("sngPallets", ref fsngPallets, value);
                }
            }
            private string m_Note;
            [Size(255)]
            public string Note
            {
                get
                {
                    return m_Note;
                }
                set
                {
                    SetPropertyValue<string>("Note", ref m_Note, value);
                }
            }
            private DateTime fExpirationDate;
            public DateTime ExpirationDate
            {
                get
                {
                    return fExpirationDate;
                }
                set
                {
                    SetPropertyValue<DateTime>("ExpirationDate", ref fExpirationDate, value);
                }
            }
            private string fFullLPNNumber;
            public string FullLPNNumber
            {
                get
                {
                    return fFullLPNNumber;
                }
                set
                {
                    SetPropertyValue<string>("FullLPNNumber", ref fFullLPNNumber, value);
                }
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
            public new class FieldsClass : XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ShipDetDetID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShipDetDetID"));
                    }
                }
                public Shipping.FieldsClass ShipDetMainID
                {
                    get
                    {
                        return new Shipping.FieldsClass(GetNestedName("ShipDetMainID"));
                    }
                }
                public Items.FieldsClass ShipDetItemID
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("ShipDetItemID"));
                    }
                }
                public const string ShipDetLotFieldName = "ShipDetLot";
                public DevExpress.Data.Filtering.OperandProperty ShipDetLot
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShipDetLot"));
                    }
                }
                public OperandProperty ShipDetDetQty
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShipDetDetQty"));
                    }
                }
                public OperandProperty sngPackages
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("sngPackages"));
                    }
                }
                public OperandProperty sngPallets
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("sngPallets"));
                    }
                }
                public const string NoteFieldName = "Note";
                public DevExpress.Data.Filtering.OperandProperty Note
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("Note"));
                    }
                }
                public const string ExpirationDateFieldName = "ExpirationDate";
                public OperandProperty ExpirationDate
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ExpirationDate"));
                    }
                }
                public const string FullLPNNuvberFieldName = "FullLPNNumber";
                public OperandProperty FullLPNNumber
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("FullLPNNumber"));
                    }
                }
            }
        }
    }
}
