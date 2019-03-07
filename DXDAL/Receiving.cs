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
                get => fReceivID;
                set => SetPropertyValue<int>("ReceivID", ref fReceivID, value);
            }
            private DateTime fReceivDate;
            public DateTime ReceivDate
            {
                get => fReceivDate;
                set => SetPropertyValue<DateTime>("ReceivDate", ref fReceivDate, value);
            }
            private Carriers fReceivCarrierID;
            public Carriers ReceivCarrierID
            {
                get => fReceivCarrierID;
                set => SetPropertyValue("ReceivCarrierID", ref fReceivCarrierID, value);
            }
            private Customers fReceivCustID;
            public Customers ReceivCustID
            {
                get => fReceivCustID;
                set => SetPropertyValue("ReceivCustID", ref fReceivCustID, value);
            }
            private string fReceivBOL;
            [Size(50)]
            public string ReceivBOL
            {
                get => fReceivBOL;
                set => SetPropertyValue("ReceivBOL", ref fReceivBOL, value);
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
            private Vendor fstrVendor;
            [Association("Receiving-Vendor")]
            public Vendor strVendor
            {
                get => fstrVendor;
                set => SetPropertyValue("strVendor", ref fstrVendor, value);
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
            private string fstrPO;
            [Size(50)]
            public string strPO
            {
                get => fstrPO;
                set => SetPropertyValue("strPO", ref fstrPO, value);
            }
            private Shifts fintShiftID;
            public Shifts intShiftID
            {
                get => fintShiftID;
                set => SetPropertyValue("intShiftID", ref fintShiftID, value);
            }
            private string fstrTrailer;
            [Size(50)]
            public string strTrailer
            {
                get => fstrTrailer;
                set => SetPropertyValue("strTrailer", ref fstrTrailer, value);
            }
            private string fstrSeal;
            [Size(50)]
            public string strSeal
            {
                get => fstrSeal;
                set => SetPropertyValue("strSeal", ref fstrSeal, value);
            }
            private string fNotes;
            [Size(255)]
            public string Notes
            {
                get => fNotes;
                set => SetPropertyValue("Notes", ref fNotes, value);
            }
            private Employees fUnloadedBy;
            [Association("Employee-Unloaded")]
            public Employees UnloadedBy
            {
                get => fUnloadedBy;
                set => SetPropertyValue("UnloadedBy", ref fUnloadedBy, value);
            }
            private Employees fCheckedBy;
            [Association("Employee-CheckedReceiving")]
            public Employees CheckedBy
            {
                get => fCheckedBy;
                set => SetPropertyValue("CheckedBy", ref fCheckedBy, value);
            }
            private ShipmentConditions fPhysicalCondition;
            [Association("ReceivingPhysicalCondition")]
            public ShipmentConditions PhysicalCondition
            {
                get => fPhysicalCondition;
                set => SetPropertyValue("PhysicalCondition", ref fPhysicalCondition, value);
            }
            private ShipmentConditions fLoadCondition;
            [Association("ReceivingLoadCondition")]
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
            private double fTemparature;
            public double Temparature
            {
                get => fTemparature;
                set => SetPropertyValue("Temparature", ref fTemparature, value);
            }
            private ThreeWayYesNo fWheelsChocked;
            public ThreeWayYesNo WheelsChocked
            {
                get => fWheelsChocked;
                set => SetPropertyValue("WheelsChocked", ref fWheelsChocked, value);
            }
            private ThreeWayYesNo fForeignSubstance;
            public ThreeWayYesNo ForeignSubstance
            {
                get => fForeignSubstance;
                set => SetPropertyValue("ForeignSubstance", ref fForeignSubstance, value);
            }
            private ThreeWayYesNo fInsectActivity;
            public ThreeWayYesNo InsectActivity
            {
                get => fInsectActivity;
                set => SetPropertyValue("InsectActivity", ref fInsectActivity, value);
            }
            private ThreeWayYesNo fCorrectPallets;
            public ThreeWayYesNo CorrectPallets
            {
                get => fCorrectPallets;
                set => SetPropertyValue("CorrectPallets", ref fCorrectPallets, value);
            }
            private Locations fReceivingLocation;
            [Association("Location-Receivings")]
            public Locations ReceivingLocation
            {
                get => fReceivingLocation;
                set => SetPropertyValue("ReceivingLocation", ref fReceivingLocation, value);
            }

            [Association("Receiving-Details", typeof(ReceivingDetail))]
            [Aggregated()]
            public XPCollection<ReceivingDetail> ReceivingDetails => GetCollection<ReceivingDetail>("ReceivingDetails");
            [Association("Receiving-Returns", typeof(ReceivedReturns))]
            [Aggregated()]
            public XPCollection<ReceivedReturns> ReceivingReturns => GetCollection<ReceivedReturns>("ReceivingReturns");
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
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty ReceivID => new OperandProperty(GetNestedName("ReceivID"));
                public OperandProperty ReceivDate => new OperandProperty(GetNestedName("ReceivDate"));
                public Carriers.FieldsClass ReceivCarrierID => new Carriers.FieldsClass(GetNestedName("ReceivCarrierID"));
                public Customers.FieldsClass ReceivCustID => new Customers.FieldsClass(GetNestedName("ReceivCustID"));
                public OperandProperty ReceivBOL => new OperandProperty(GetNestedName("ReceivBOL"));
                public OperandProperty strEnteredBy => new OperandProperty(GetNestedName("strEnteredBy"));
                public OperandProperty dtmEnteredOn => new OperandProperty(GetNestedName("dtmEnteredOn"));
                public Vendor.FieldsClass strVendor => new Vendor.FieldsClass(GetNestedName("strVendor"));
                public OperandProperty sngSkits => new OperandProperty(GetNestedName("sngSkits"));
                public OperandProperty sngTotalPallets => new OperandProperty(GetNestedName("sngTotalPallets"));
                public OperandProperty strPO => new OperandProperty(GetNestedName("strPO"));
                public OperandProperty intShiftID => new OperandProperty(GetNestedName("intShiftID"));
                public OperandProperty strTrailer => new OperandProperty(GetNestedName("strTrailer"));
                public OperandProperty strSeal => new OperandProperty(GetNestedName("strSeal"));
                public OperandProperty Notes => new OperandProperty(GetNestedName("Notes"));
                public OperandProperty UnloadedBy => new OperandProperty(GetNestedName("UnloadedBy"));
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
                public Locations.FieldsClass ReceivingLocation => new Locations.FieldsClass(GetNestedName("ReceivingLocation"));
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
