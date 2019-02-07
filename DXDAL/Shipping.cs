using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblShipMain")]
        public class Shipping : XPLiteObject
        {
            private int fShipMainID;
            [Key()]
            public int ShipMainID
            {
                get
                {
                    return fShipMainID;
                }
                set
                {
                    SetPropertyValue<int>("ShipMainID", ref fShipMainID, value);
                }
            }
            private DateTime fShipMainDate;
            public DateTime ShipMainDate
            {
                get
                {
                    return fShipMainDate;
                }
                set
                {
                    SetPropertyValue<DateTime>("ShipMainDate", ref fShipMainDate, value);
                }
            }
            private Carriers fShipMainCarrierID;
            public Carriers ShipMainCarrierID
            {
                get
                {
                    return fShipMainCarrierID;
                }
                set
                {
                    SetPropertyValue("ShipMainCarrierID", ref fShipMainCarrierID, value);
                }
            }
            private Customers fShipMainCustID;
            public Customers ShipMainCustID
            {
                get
                {
                    return fShipMainCustID;
                }
                set
                {
                    SetPropertyValue("ShipMainCustID", ref fShipMainCustID, value);
                }
            }
            private int fShipMainBOL;
            public int ShipMainBOL
            {
                get
                {
                    return fShipMainBOL;
                }
                set
                {
                    SetPropertyValue<int>("ShipMainBOL", ref fShipMainBOL, value);
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
                    SetPropertyValue("strEnteredBy", ref fstrEnteredBy, value);
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
            private ShippingAddresses fintDestination;
            public ShippingAddresses intDestination
            {
                get
                {
                    return fintDestination;
                }
                set
                {
                    SetPropertyValue("intDestination", ref fintDestination, value);
                }
            }
            private string fstrPO;
            [Size(50)]
            public string strPO
            {
                get
                {
                    return fstrPO;
                }
                set
                {
                    SetPropertyValue("strPO", ref fstrPO, value);
                }
            }
            private string fstrTrailer;
            [Size(50)]
            public string strTrailer
            {
                get
                {
                    return fstrTrailer;
                }
                set
                {
                    SetPropertyValue("strTrailer", ref fstrTrailer, value);
                }
            }
            private float fsngSkits;
            public float sngSkits
            {
                get
                {
                    return fsngSkits;
                }
                set
                {
                    SetPropertyValue("sngSkits", ref fsngSkits, value);
                }
            }
            private float fsngTotalPallets;
            public float sngTotalPallets
            {
                get
                {
                    return fsngTotalPallets;
                }
                set
                {
                    SetPropertyValue("sngTotalPallets", ref fsngTotalPallets, value);
                }
            }
            private string fstrSeal;
            [Size(50)]
            public string strSeal
            {
                get
                {
                    return fstrSeal;
                }
                set
                {
                    SetPropertyValue("strSeal", ref fstrSeal, value);
                }
            }
            private string fstrRoute;
            [Size(50)]
            public string strRoute
            {
                get
                {
                    return fstrRoute;
                }
                set
                {
                    SetPropertyValue("strRoute", ref fstrRoute, value);
                }
            }
            private string fstrDeliveryNote;
            public string strDeliveryNote
            {
                get
                {
                    return fstrDeliveryNote;
                }
                set
                {
                    SetPropertyValue("strDeliveryNote", ref fstrDeliveryNote, value);
                }
            }
            private string fDeliveryNoteNumber;
            [Size(50)]
            public string DeliveryNoteNumber
            {
                get
                {
                    return fDeliveryNoteNumber;
                }
                set
                {
                    SetPropertyValue("DeliveryNoteNumber", ref fDeliveryNoteNumber, value);
                }
            }
            private double fTotalGrossWeight;
            public double TotalGrossWeight
            {
                get
                {
                    return fTotalGrossWeight;
                }
                set
                {
                    SetPropertyValue("TotalGrossWeight", ref fTotalGrossWeight, value);
                }
            }
            private bool fShipper;
            public bool Shipper
            {
                get
                {
                    return fShipper;
                }
                set
                {
                    SetPropertyValue("Shipper", ref fShipper, value);
                }
            }
            private string fComments;
            [Size(255)]
            public string Comments
            {
                get
                {
                    return fComments;
                }
                set
                {
                    SetPropertyValue("Comments", ref fComments, value);
                }
            }
            private Shifts fShift;
            public Shifts Shift
            {
                get
                {
                    return fShift;
                }
                set
                {
                    SetPropertyValue("Shift", ref fShift, value);
                }
            }
            private bool fFreight;
            public bool Freight
            {
                get
                {
                    return fFreight;
                }
                set
                {
                    SetPropertyValue("Freight", ref fFreight, value);
                }
            }
            private Employees fLoadedBy;
            [Association("Employee-Loaded")]
            public Employees LoadedBy
            {
                get
                {
                    return fLoadedBy;
                }
                set
                {
                    SetPropertyValue("LoadedBy", ref fLoadedBy, value);
                }
            }
            private Employees fCheckedBy;
            [Association("Employee-CheckedShipping")]
            public Employees CheckedBy
            {
                get
                {
                    return fCheckedBy;
                }
                set
                {
                    SetPropertyValue("CheckedBy", ref fCheckedBy, value);
                }
            }
            private ShipmentConditions fPhysicalCondition;
            [Association("ShipingPhysicalCondition")]
            public ShipmentConditions PhysicalCondition
            {
                get
                {
                    return fPhysicalCondition;
                }
                set
                {
                    SetPropertyValue("PhysicalCondition", ref fPhysicalCondition, value);
                }
            }
            private ShipmentConditions fLoadCondition;
            [Association("ShipingLoadCondition")]
            public ShipmentConditions LoadCondition
            {
                get
                {
                    return fLoadCondition;
                }
                set
                {
                    SetPropertyValue("LoadCondition", ref fLoadCondition, value);
                }
            }
            private DateTime fStartTime;
            public DateTime StartTime
            {
                get
                {
                    return fStartTime;
                }
                set
                {
                    SetPropertyValue<DateTime>("StartTime", ref fStartTime, value);
                }
            }
            private DateTime fFinishTime;
            public DateTime FinishTime
            {
                get
                {
                    return fFinishTime;
                }
                set
                {
                    SetPropertyValue<DateTime>("FinishTime", ref fFinishTime, value);
                }
            }
            private double? fTemparature;
            public double? Temparature
            {
                get
                {
                    return fTemparature;
                }
                set
                {
                    SetPropertyValue("Temparature", ref fTemparature, value);
                }
            }
            private ThreeWayYesNo? fWheelsChocked;
            public ThreeWayYesNo? WheelsChocked
            {
                get
                {
                    return fWheelsChocked;
                }
                set
                {
                    SetPropertyValue("WheelsChocked", ref fWheelsChocked, value);
                }
            }
            private ThreeWayYesNo? fForeignSubstance;
            public ThreeWayYesNo? ForeignSubstance
            {
                get
                {
                    return fForeignSubstance;
                }
                set
                {
                    SetPropertyValue("ForeignSubstance", ref fForeignSubstance, value);
                }
            }
            private ThreeWayYesNo? fInsectActivity;
            public ThreeWayYesNo? InsectActivity
            {
                get
                {
                    return fInsectActivity;
                }
                set
                {
                    SetPropertyValue("InsectActivity", ref fInsectActivity, value);
                }
            }
            private ThreeWayYesNo? fCorrectPallets;
            public ThreeWayYesNo? CorrectPallets
            {
                get
                {
                    return fCorrectPallets;
                }
                set
                {
                    SetPropertyValue("CorrectPallets", ref fCorrectPallets, value);
                }
            }
            private Locations fShippingLocation;
            [Association("Location-Shippings")]
            public Locations ShippingLocation
            {
                get
                {
                    return fShippingLocation;
                }
                set
                {
                    SetPropertyValue("ShippingLocation", ref fShippingLocation, value);
                }
            }

            [Association("Shipping-Details", typeof(ShipDet))]
            [Aggregated()]
            public XPCollection<ShipDet> ShippingDetails
            {
                get
                {
                    return GetCollection<ShipDet>("ShippingDetails");
                }
            }
            [Association("Shippiing-Returns", typeof(ShippedReturns))]
            [Aggregated()]
            public XPCollection<ShippedReturns> ShippingReturns
            {
                get
                {
                    return GetCollection<ShippedReturns>("ShippingReturns");
                }
            }
            public Shipping(Session session) : base(session)
            {
            }
            public Shipping() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
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
            // Created/Updated: Joel-PC\Joel on JOEL-PC at 7/06/10 4:39 PM
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ShipMainID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShipMainID"));
                    }
                }
                public OperandProperty ShipMainDate
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShipMainDate"));
                    }
                }
                public Carriers.FieldsClass ShipMainCarrierID
                {
                    get
                    {
                        return new Carriers.FieldsClass(GetNestedName("ShipMainCarrierID"));
                    }
                }
                public Customers.FieldsClass ShipMainCustID
                {
                    get
                    {
                        return new Customers.FieldsClass(GetNestedName("ShipMainCustID"));
                    }
                }
                public OperandProperty ShipMainBOL
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShipMainBOL"));
                    }
                }
                public OperandProperty strEnteredBy
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strEnteredBy"));
                    }
                }
                public OperandProperty dtmEnteredOn
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("dtmEnteredOn"));
                    }
                }
                public ShippingAddresses.FieldsClass intDestination
                {
                    get
                    {
                        return new ShippingAddresses.FieldsClass(GetNestedName("intDestination"));
                    }
                }
                public OperandProperty strPO
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strPO"));
                    }
                }
                public OperandProperty strTrailer
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strTrailer"));
                    }
                }
                public OperandProperty sngSkits
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("sngSkits"));
                    }
                }
                public OperandProperty sngTotalPallets
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("sngTotalPallets"));
                    }
                }
                public OperandProperty strSeal
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strSeal"));
                    }
                }
                public OperandProperty strRoute
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strRoute"));
                    }
                }
                public OperandProperty strDeliveryNote
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strDeliveryNote"));
                    }
                }
                public OperandProperty DeliveryNoteNumber
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("DeliveryNoteNumber"));
                    }
                }
                public OperandProperty TotalGrossWeight
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("TotalGrossWeight"));
                    }
                }
                public OperandProperty Shipper
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Shipper"));
                    }
                }
                public OperandProperty Comments
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Comments"));
                    }
                }
                public OperandProperty Shift
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Shift"));
                    }
                }
                public OperandProperty Freight
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Freight"));
                    }
                }
                public OperandProperty ShippingDetails
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShippingDetails"));
                    }
                }
                public OperandProperty ShippingReturns
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ShippingReturns"));
                    }
                }
                public OperandProperty LoadedBy
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LoadedBy"));
                    }
                }
                public OperandProperty CheckedBy
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CheckedBy"));
                    }
                }
                public OperandProperty PhysicalCondition
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PhysicalCondition"));
                    }
                }
                public OperandProperty LoadCondition
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LoadCondition"));
                    }
                }
                public OperandProperty StartTime
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("StartTime"));
                    }
                }
                public OperandProperty FinishTime
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("FinishTime"));
                    }
                }
                public OperandProperty Temparature
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Temparature"));
                    }
                }
                public OperandProperty WheelsChocked
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("WheelsChocked"));
                    }
                }
                public OperandProperty ForeignSubstance
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ForeignSubstance"));
                    }
                }
                public OperandProperty InsectActivity
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("InsectActivity"));
                    }
                }
                public OperandProperty CorrectPallets
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("CorrectPallets"));
                    }
                }
                public Locations.FieldsClass ShippingLocation
                {
                    get
                    {
                        return new Locations.FieldsClass(GetNestedName("ShippingLocation"));
                    }
                }
            }
        }
    }
}
