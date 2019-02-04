using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Collections;
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Xpo.Helpers;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblReceivMain")]
        public class Receiving : XPLiteObject
        {
            private int fReceivID;
            [Key()]
            public int ReceivID
            {
                get
                {
                    return fReceivID;
                }
                set
                {
                    SetPropertyValue<int>("ReceivID", ref fReceivID, value);
                }
            }
            private DateTime fReceivDate;
            public DateTime ReceivDate
            {
                get
                {
                    return fReceivDate;
                }
                set
                {
                    SetPropertyValue<DateTime>("ReceivDate", ref fReceivDate, value);
                }
            }
            private Carriers fReceivCarrierID;
            public Carriers ReceivCarrierID
            {
                get
                {
                    return fReceivCarrierID;
                }
                set
                {
                    SetPropertyValue<Carriers>("ReceivCarrierID", ref fReceivCarrierID, value);
                }
            }
            private Customers fReceivCustID;
            public Customers ReceivCustID
            {
                get
                {
                    return fReceivCustID;
                }
                set
                {
                    SetPropertyValue<Customers>("ReceivCustID", ref fReceivCustID, value);
                }
            }
            private string fReceivBOL;
            [Size(50)]
            public string ReceivBOL
            {
                get
                {
                    return fReceivBOL;
                }
                set
                {
                    SetPropertyValue<string>("ReceivBOL", ref fReceivBOL, value);
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
            private Vendor fstrVendor;
            [Association("Receiving-Vendor")]
            public Vendor strVendor
            {
                get
                {
                    return fstrVendor;
                }
                set
                {
                    SetPropertyValue<Vendor>("strVendor", ref fstrVendor, value);
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
            private Shifts fintShiftID;
            public Shifts intShiftID
            {
                get
                {
                    return fintShiftID;
                }
                set
                {
                    SetPropertyValue<Shifts>("intShiftID", ref fintShiftID, value);
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
            private string fNotes;
            [Size(255)]
            public string Notes
            {
                get
                {
                    return fNotes;
                }
                set
                {
                    SetPropertyValue<string>("Notes", ref fNotes, value);
                }
            }
            private Employees fUnloadedBy;
            [Association("Employee-Unloaded")]
            public Employees UnloadedBy
            {
                get
                {
                    return fUnloadedBy;
                }
                set
                {
                    SetPropertyValue<Employees>("UnloadedBy", ref fUnloadedBy, value);
                }
            }
            private Employees fCheckedBy;
            [Association("Employee-CheckedReceiving")]
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
            [Association("ReceivingPhysicalCondition")]
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
            [Association("ReceivingLoadCondition")]
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
            private Locations fReceivingLocation;
            [Association("Location-Receivings")]
            public Locations ReceivingLocation
            {
                get
                {
                    return fReceivingLocation;
                }
                set
                {
                    SetPropertyValue<Locations>("ReceivingLocation", ref fReceivingLocation, value);
                }
            }

            [Association("Receiving-Details", typeof(ReceivingDetail))]
            [Aggregated()]
            public XPCollection<ReceivingDetail> ReceivingDetails
            {
                get
                {
                    return GetCollection<ReceivingDetail>("ReceivingDetails");
                }
            }
            [Association("Receiving-Returns", typeof(ReceivedReturns))]
            [Aggregated()]
            public XPCollection<ReceivedReturns> ReceivingReturns
            {
                get
                {
                    return GetCollection<ReceivedReturns>("ReceivingReturns");
                }
            }
            public Receiving(Session session) : base(session)
            {
            }
            public Receiving() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }
            public new class FieldsClass : DevExpress.Xpo.PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ReceivID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ReceivID"));
                    }
                }
                public OperandProperty ReceivDate
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ReceivDate"));
                    }
                }
                public Carriers.FieldsClass ReceivCarrierID
                {
                    get
                    {
                        return new Carriers.FieldsClass(GetNestedName("ReceivCarrierID"));
                    }
                }
                public Customers.FieldsClass ReceivCustID
                {
                    get
                    {
                        return new Customers.FieldsClass(GetNestedName("ReceivCustID"));
                    }
                }
                public OperandProperty ReceivBOL
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ReceivBOL"));
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
                public Vendor.FieldsClass strVendor
                {
                    get
                    {
                        return new Vendor.FieldsClass(GetNestedName("strVendor"));
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
                public OperandProperty strPO
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strPO"));
                    }
                }
                public OperandProperty intShiftID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("intShiftID"));
                    }
                }
                public OperandProperty strTrailer
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strTrailer"));
                    }
                }
                public OperandProperty strSeal
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("strSeal"));
                    }
                }
                public OperandProperty Notes
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Notes"));
                    }
                }
                public OperandProperty UnloadedBy
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("UnloadedBy"));
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
                public Locations.FieldsClass ReceivingLocation
                {
                    get
                    {
                        return new Locations.FieldsClass(GetNestedName("ReceivingLocation"));
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
