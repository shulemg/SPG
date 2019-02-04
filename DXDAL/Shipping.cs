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
                    SetPropertyValue<Carriers>("ShipMainCarrierID", ref fShipMainCarrierID, value);
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
                    SetPropertyValue<Customers>("ShipMainCustID", ref fShipMainCustID, value);
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
            private ShippingAddresses fintDestination;
            public ShippingAddresses intDestination
            {
                get
                {
                    return fintDestination;
                }
                set
                {
                    SetPropertyValue<ShippingAddresses>("intDestination", ref fintDestination, value);
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
                    SetPropertyValue<string>("strPO", ref fstrPO, value);
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
                    SetPropertyValue<string>("strTrailer", ref fstrTrailer, value);
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
                    SetPropertyValue<float>("sngSkits", ref fsngSkits, value);
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
                    SetPropertyValue<float>("sngTotalPallets", ref fsngTotalPallets, value);
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
                    SetPropertyValue<string>("strSeal", ref fstrSeal, value);
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
                    SetPropertyValue<string>("strRoute", ref fstrRoute, value);
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
                    SetPropertyValue<string>("strDeliveryNote", ref fstrDeliveryNote, value);
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
                    SetPropertyValue<string>("DeliveryNoteNumber", ref fDeliveryNoteNumber, value);
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
                    SetPropertyValue<double>("TotalGrossWeight", ref fTotalGrossWeight, value);
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
                    SetPropertyValue<bool>("Shipper", ref fShipper, value);
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
                    SetPropertyValue<string>("Comments", ref fComments, value);
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
                    SetPropertyValue<Shifts>("Shift", ref fShift, value);
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
                    SetPropertyValue<bool>("Freight", ref fFreight, value);
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
                    SetPropertyValue<Employees>("LoadedBy", ref fLoadedBy, value);
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
                    SetPropertyValue<Employees>("CheckedBy", ref fCheckedBy, value);
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
                    SetPropertyValue<ShipmentConditions>("PhysicalCondition", ref fPhysicalCondition, value);
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
                    SetPropertyValue<ShipmentConditions>("LoadCondition", ref fLoadCondition, value);
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
            private double fTemparature;
            public double Temparature
            {
                get
                {
                    return fTemparature;
                }
                set
                {
                    SetPropertyValue<double>("Temparature", ref fTemparature, value);
                }
            }
            private ThreeWayYesNo fWheelsChocked;
            public ThreeWayYesNo WheelsChocked
            {
                get
                {
                    return fWheelsChocked;
                }
                set
                {
                    SetPropertyValue<ThreeWayYesNo>("WheelsChocked", ref fWheelsChocked, value);
                }
            }
            private ThreeWayYesNo fForeignSubstance;
            public ThreeWayYesNo ForeignSubstance
            {
                get
                {
                    return fForeignSubstance;
                }
                set
                {
                    SetPropertyValue<ThreeWayYesNo>("ForeignSubstance", ref fForeignSubstance, value);
                }
            }
            private ThreeWayYesNo fInsectActivity;
            public ThreeWayYesNo InsectActivity
            {
                get
                {
                    return fInsectActivity;
                }
                set
                {
                    SetPropertyValue<ThreeWayYesNo>("InsectActivity", ref fInsectActivity, value);
                }
            }
            private ThreeWayYesNo fCorrectPallets;
            public ThreeWayYesNo CorrectPallets
            {
                get
                {
                    return fCorrectPallets;
                }
                set
                {
                    SetPropertyValue<ThreeWayYesNo>("CorrectPallets", ref fCorrectPallets, value);
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
                    SetPropertyValue<Locations>("ShippingLocation", ref fShippingLocation, value);
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
            public new class FieldsClass : DevExpress.Xpo.XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public DevExpress.Data.Filtering.OperandProperty ShipMainID
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShipMainID"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty ShipMainDate
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShipMainDate"));
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
                public DevExpress.Data.Filtering.OperandProperty ShipMainBOL
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShipMainBOL"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty strEnteredBy
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("strEnteredBy"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty dtmEnteredOn
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("dtmEnteredOn"));
                    }
                }
                public ShippingAddresses.FieldsClass intDestination
                {
                    get
                    {
                        return new ShippingAddresses.FieldsClass(GetNestedName("intDestination"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty strPO
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("strPO"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty strTrailer
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("strTrailer"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty sngSkits
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("sngSkits"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty sngTotalPallets
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("sngTotalPallets"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty strSeal
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("strSeal"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty strRoute
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("strRoute"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty strDeliveryNote
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("strDeliveryNote"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty DeliveryNoteNumber
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("DeliveryNoteNumber"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty TotalGrossWeight
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("TotalGrossWeight"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty Shipper
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("Shipper"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty Comments
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("Comments"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty Shift
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("Shift"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty Freight
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("Freight"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty ShippingDetails
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShippingDetails"));
                    }
                }
                public DevExpress.Data.Filtering.OperandProperty ShippingReturns
                {
                    get
                    {
                        return new DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShippingReturns"));
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
