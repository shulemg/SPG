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
                get => fShipMainID;
                set => SetPropertyValue<int>("ShipMainID", ref fShipMainID, value);
            }
            private DateTime fShipMainDate;
            public DateTime ShipMainDate
            {
                get => fShipMainDate;
                set => SetPropertyValue<DateTime>("ShipMainDate", ref fShipMainDate, value);
            }
            private Carriers fShipMainCarrierID;
            public Carriers ShipMainCarrierID
            {
                get => fShipMainCarrierID;
                set => SetPropertyValue("ShipMainCarrierID", ref fShipMainCarrierID, value);
            }
            private Customers fShipMainCustID;
            public Customers ShipMainCustID
            {
                get => fShipMainCustID;
                set => SetPropertyValue("ShipMainCustID", ref fShipMainCustID, value);
            }
            private int fShipMainBOL;
            public int ShipMainBOL
            {
                get => fShipMainBOL;
                set => SetPropertyValue<int>("ShipMainBOL", ref fShipMainBOL, value);
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
            private ShippingAddresses fintDestination;
            public ShippingAddresses intDestination
            {
                get => fintDestination;
                set => SetPropertyValue("intDestination", ref fintDestination, value);
            }
            private string fstrPO;
            [Size(50)]
            public string strPO
            {
                get => fstrPO;
                set => SetPropertyValue("strPO", ref fstrPO, value);
            }
            private string fstrTrailer;
            [Size(50)]
            public string strTrailer
            {
                get => fstrTrailer;
                set => SetPropertyValue("strTrailer", ref fstrTrailer, value);
            }
            private float fsngSkits;
            public float sngSkits
            {
                get => fsngSkits;
                set => SetPropertyValue("sngSkits", ref fsngSkits, value);
            }
            private float fsngTotalPallets;
            public float sngTotalPallets
            {
                get => fsngTotalPallets;
                set => SetPropertyValue("sngTotalPallets", ref fsngTotalPallets, value);
            }
            private string fstrSeal;
            [Size(50)]
            public string strSeal
            {
                get => fstrSeal;
                set => SetPropertyValue("strSeal", ref fstrSeal, value);
            }
            private string fstrRoute;
            [Size(50)]
            public string strRoute
            {
                get => fstrRoute;
                set => SetPropertyValue("strRoute", ref fstrRoute, value);
            }
            private string fstrDeliveryNote;
            public string strDeliveryNote
            {
                get => fstrDeliveryNote;
                set => SetPropertyValue("strDeliveryNote", ref fstrDeliveryNote, value);
            }
            private string fDeliveryNoteNumber;
            [Size(50)]
            public string DeliveryNoteNumber
            {
                get => fDeliveryNoteNumber;
                set => SetPropertyValue("DeliveryNoteNumber", ref fDeliveryNoteNumber, value);
            }
            private double fTotalGrossWeight;
            public double TotalGrossWeight
            {
                get => fTotalGrossWeight;
                set => SetPropertyValue("TotalGrossWeight", ref fTotalGrossWeight, value);
            }
            private bool fShipper;
            public bool Shipper
            {
                get => fShipper;
                set => SetPropertyValue("Shipper", ref fShipper, value);
            }
            private string fComments;
            [Size(255)]
            public string Comments
            {
                get => fComments;
                set => SetPropertyValue("Comments", ref fComments, value);
            }
            private Shifts fShift;
            public Shifts Shift
            {
                get => fShift;
                set => SetPropertyValue("Shift", ref fShift, value);
            }
            private bool fFreight;
            public bool Freight
            {
                get => fFreight;
                set => SetPropertyValue("Freight", ref fFreight, value);
            }
            private Employees fLoadedBy;
            [Association("Employee-Loaded")]
            public Employees LoadedBy
            {
                get => fLoadedBy;
                set => SetPropertyValue("LoadedBy", ref fLoadedBy, value);
            }
            private Employees fCheckedBy;
            [Association("Employee-CheckedShipping")]
            public Employees CheckedBy
            {
                get => fCheckedBy;
                set => SetPropertyValue("CheckedBy", ref fCheckedBy, value);
            }
            private ShipmentConditions fPhysicalCondition;
            [Association("ShipingPhysicalCondition")]
            public ShipmentConditions PhysicalCondition
            {
                get => fPhysicalCondition;
                set => SetPropertyValue("PhysicalCondition", ref fPhysicalCondition, value);
            }
            private ShipmentConditions fLoadCondition;
            [Association("ShipingLoadCondition")]
            public ShipmentConditions LoadCondition
            {
                get => fLoadCondition;
                set => SetPropertyValue("LoadCondition", ref fLoadCondition, value);
            }
            private DateTime fStartTime;
            public DateTime StartTime
            {
                get => fStartTime;
                set => SetPropertyValue<DateTime>("StartTime", ref fStartTime, value);
            }
            private DateTime fFinishTime;
            public DateTime FinishTime
            {
                get => fFinishTime;
                set => SetPropertyValue<DateTime>("FinishTime", ref fFinishTime, value);
            }
            private double? fTemparature;
            public double? Temparature
            {
                get => fTemparature;
                set => SetPropertyValue("Temparature", ref fTemparature, value);
            }
            private ThreeWayYesNo? fWheelsChocked;
            public ThreeWayYesNo? WheelsChocked
            {
                get => fWheelsChocked;
                set => SetPropertyValue("WheelsChocked", ref fWheelsChocked, value);
            }
            private ThreeWayYesNo? fForeignSubstance;
            public ThreeWayYesNo? ForeignSubstance
            {
                get => fForeignSubstance;
                set => SetPropertyValue("ForeignSubstance", ref fForeignSubstance, value);
            }
            private ThreeWayYesNo? fInsectActivity;
            public ThreeWayYesNo? InsectActivity
            {
                get => fInsectActivity;
                set => SetPropertyValue("InsectActivity", ref fInsectActivity, value);
            }
            private ThreeWayYesNo? fCorrectPallets;
            public ThreeWayYesNo? CorrectPallets
            {
                get => fCorrectPallets;
                set => SetPropertyValue("CorrectPallets", ref fCorrectPallets, value);
            }
            private Locations fShippingLocation;
            [Association("Location-Shippings")]
            public Locations ShippingLocation
            {
                get => fShippingLocation;
                set => SetPropertyValue("ShippingLocation", ref fShippingLocation, value);
            }

            [Association("Shipping-Details", typeof(ShipDet))]
            [Aggregated()]
            public XPCollection<ShipDet> ShippingDetails => GetCollection<ShipDet>("ShippingDetails");
            [Association("Shippiing-Returns", typeof(ShippedReturns))]
            [Aggregated()]
            public XPCollection<ShippedReturns> ShippingReturns => GetCollection<ShippedReturns>("ShippingReturns");
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
                public OperandProperty ShipMainID => new OperandProperty(GetNestedName("ShipMainID"));
                public OperandProperty ShipMainDate => new OperandProperty(GetNestedName("ShipMainDate"));
                public Carriers.FieldsClass ShipMainCarrierID => new Carriers.FieldsClass(GetNestedName("ShipMainCarrierID"));
                public Customers.FieldsClass ShipMainCustID => new Customers.FieldsClass(GetNestedName("ShipMainCustID"));
                public OperandProperty ShipMainBOL => new OperandProperty(GetNestedName("ShipMainBOL"));
                public OperandProperty strEnteredBy => new OperandProperty(GetNestedName("strEnteredBy"));
                public OperandProperty dtmEnteredOn => new OperandProperty(GetNestedName("dtmEnteredOn"));
                public ShippingAddresses.FieldsClass intDestination => new ShippingAddresses.FieldsClass(GetNestedName("intDestination"));
                public OperandProperty strPO => new OperandProperty(GetNestedName("strPO"));
                public OperandProperty strTrailer => new OperandProperty(GetNestedName("strTrailer"));
                public OperandProperty sngSkits => new OperandProperty(GetNestedName("sngSkits"));
                public OperandProperty sngTotalPallets => new OperandProperty(GetNestedName("sngTotalPallets"));
                public OperandProperty strSeal => new OperandProperty(GetNestedName("strSeal"));
                public OperandProperty strRoute => new OperandProperty(GetNestedName("strRoute"));
                public OperandProperty strDeliveryNote => new OperandProperty(GetNestedName("strDeliveryNote"));
                public OperandProperty DeliveryNoteNumber => new OperandProperty(GetNestedName("DeliveryNoteNumber"));
                public OperandProperty TotalGrossWeight => new OperandProperty(GetNestedName("TotalGrossWeight"));
                public OperandProperty Shipper => new OperandProperty(GetNestedName("Shipper"));
                public OperandProperty Comments => new OperandProperty(GetNestedName("Comments"));
                public OperandProperty Shift => new OperandProperty(GetNestedName("Shift"));
                public OperandProperty Freight => new OperandProperty(GetNestedName("Freight"));
                public OperandProperty ShippingDetails => new OperandProperty(GetNestedName("ShippingDetails"));
                public OperandProperty ShippingReturns => new OperandProperty(GetNestedName("ShippingReturns"));
                public OperandProperty LoadedBy => new OperandProperty(GetNestedName("LoadedBy"));
                public OperandProperty CheckedBy => new OperandProperty(GetNestedName("CheckedBy"));
                public OperandProperty PhysicalCondition => new OperandProperty(GetNestedName("PhysicalCondition"));
                public OperandProperty LoadCondition => new OperandProperty(GetNestedName("LoadCondition"));
                public OperandProperty StartTime => new OperandProperty(GetNestedName("StartTime"));
                public OperandProperty FinishTime => new OperandProperty(GetNestedName("FinishTime"));
                public OperandProperty Temparature => new OperandProperty(GetNestedName("Temparature"));
                public OperandProperty WheelsChocked => new OperandProperty(GetNestedName("WheelsChocked"));
                public OperandProperty ForeignSubstance => new OperandProperty(GetNestedName("ForeignSubstance"));
                public OperandProperty InsectActivity => new OperandProperty(GetNestedName("InsectActivity"));
                public OperandProperty CorrectPallets => new OperandProperty(GetNestedName("CorrectPallets"));
                public Locations.FieldsClass ShippingLocation => new Locations.FieldsClass(GetNestedName("ShippingLocation"));
            }
        }
    }
}
