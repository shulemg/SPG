using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblShipReturnDet")]
        public class ShippedReturns : XPLiteObject
        {
            private int fReturnDetID;
            [Key(true)]
            public int ReturnDetID
            {
                get
                {
                    return fReturnDetID;
                }
                set
                {
                    SetPropertyValue<int>("ReturnDetID", ref fReturnDetID, value);
                }
            }
            private Shipping fShipMainID;
            [Association("Shippiing-Returns")]
            public Shipping ShipMainID
            {
                get
                {
                    return fShipMainID;
                }
                set
                {
                    SetPropertyValue<Shipping>("ShipMainID", ref fShipMainID, value);
                }
            }
            private Items fReturnDetItemID;
            public Items ReturnDetItemID
            {
                get
                {
                    return fReturnDetItemID;
                }
                set
                {
                    SetPropertyValue<Items>("ReturnDetItemID", ref fReturnDetItemID, value);
                }
            }
            private string fReturnDetLot;
            [Size(150)]
            public string ReturnDetLot
            {
                get
                {
                    return fReturnDetLot;
                }
                set
                {
                    SetPropertyValue<string>("ReturnDetLot", ref fReturnDetLot, value);
                }
            }
            private int fReturnDetQty;
            public int ReturnDetQty
            {
                get
                {
                    return fReturnDetQty;
                }
                set
                {
                    SetPropertyValue<int>("ReturnDetQty", ref fReturnDetQty, value);
                }
            }
            private int fintUnits;
            public int intUnits
            {
                get
                {
                    return fintUnits;
                }
                set
                {
                    SetPropertyValue<int>("intUnits", ref fintUnits, value);
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
            private string fReason;
            [Size(255)]
            public string Reason
            {
                get
                {
                    return fReason;
                }
                set
                {
                    SetPropertyValue<string>("Reason", ref fReason, value);
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
            public ShippedReturns(Session session) : base(session)
            {
            }
            public ShippedReturns() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }
            // Created/Updated: Joel-PC\Joel on JOEL-PC at 1/27/2013 5:06 PM
            public new class FieldsClass : XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ReturnDetID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ReturnDetID"));
                    }
                }
                public Shipping.FieldsClass ShipMainID
                {
                    get
                    {
                        return new Shipping.FieldsClass(GetNestedName("ShipMainID"));
                    }
                }
                public Items.FieldsClass ReturnDetItemID
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("ReturnDetItemID"));
                    }
                }
                public const string ReturnDetLotFieldName = "ReturnDetLot";
                public DevExpress.Data.Filtering.OperandProperty ReturnDetLot
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ReturnDetLot"));
                    }
                }
                public OperandProperty ReturnDetQty
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ReturnDetQty"));
                    }
                }
                public OperandProperty intUnits
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("intUnits"));
                    }
                }
                public OperandProperty sngPallets
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("sngPallets"));
                    }
                }
                public const string ReasonFieldName = "Reason";
                public DevExpress.Data.Filtering.OperandProperty Reason
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("Reason"));
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
