using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Collections;
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Helpers;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblInventoryAdjustment")]
        public class InventoryAdjustment : XPLiteObject
        {
            private int fAdjustmentID;
            [Key(true)]
            public int AdjustmentID
            {
                get
                {
                    return fAdjustmentID;
                }
                set
                {
                    SetPropertyValue<int>("AdjustmentID", ref fAdjustmentID, value);
                }
            }
            private DateTime fAdjustmentDate;
            public DateTime AdjustmentDate
            {
                get
                {
                    return fAdjustmentDate;
                }
                set
                {
                    SetPropertyValue<DateTime>("AdjustmentDate", ref fAdjustmentDate, value);
                }
            }
            private Customers fCustomer;
            public Customers Customer
            {
                get
                {
                    return fCustomer;
                }
                set
                {
                    SetPropertyValue("Customer", ref fCustomer, value);
                }
            }
            private Items fItem;
            [Persistent("Item")]
            public Items AdjustmentItem
            {
                get
                {
                    return fItem;
                }
                set
                {
                    SetPropertyValue("AdjustmentItem", ref fItem, value);
                }
            }
            private float fOriginalQuantity;
            public float OriginalQuantity
            {
                get
                {
                    return fOriginalQuantity;
                }
                set
                {
                    SetPropertyValue("OriginalQuantity", ref fOriginalQuantity, value);
                }
            }
            private float? fNewCount;
            public float? NewCount
            {
                get
                {
                    return fNewCount;
                }
                set
                {
                    SetPropertyValue("NewCount", ref fNewCount, value);
                }
            }
            private string fOriginalLot;
            public string OriginalLot
            {
                get
                {
                    return fOriginalLot;
                }
                set
                {
                    SetPropertyValue("OriginalLot", ref fOriginalLot, value);
                }
            }
            private string fNewLot;
            public string NewLot
            {
                get
                {
                    return fNewLot;
                }
                set
                {
                    SetPropertyValue("NewLot", ref fNewLot, value);
                }
            }
            private int? fLPN;
            public int? LPN
            {
                get
                {
                    return fLPN;
                }
                set
                {
                    SetPropertyValue("LPN", ref fLPN, value);
                }
            }
            private string fReason;
            [Size(150)]
            public string Reason
            {
                get
                {
                    return fReason;
                }
                set
                {
                    SetPropertyValue("Reason", ref fReason, value);
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
            private Locations fInventoryLocation;
            public Locations InventoryLocation
            {
                get
                {
                    return fInventoryLocation;
                }
                set
                {
                    SetPropertyValue("InventoryLocation", ref fInventoryLocation, value);
                }
            }
            public InventoryAdjustment(Session session) : base(session)
            {
            }
            public InventoryAdjustment() : base(Session.DefaultSession)
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
                public OperandProperty AdjustmentID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("AdjustmentID"));
                    }
                }
                public OperandProperty AdjustmentDate
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("AdjustmentDate"));
                    }
                }
                public Customers.FieldsClass Customer
                {
                    get
                    {
                        return new Customers.FieldsClass(GetNestedName("Customer"));
                    }
                }
                public Items.FieldsClass AdjustmentItem
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("AdjustmentItem"));
                    }
                }
                public OperandProperty OriginalQuantity
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("OriginalQuantity"));
                    }
                }
                public OperandProperty NewCount
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("NewCount"));
                    }
                }
                public OperandProperty OriginalLot
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("OriginalLot"));
                    }
                }
                public OperandProperty NewLot
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("NewLot"));
                    }
                }
                public OperandProperty LPN
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("LPN"));
                    }
                }
                public OperandProperty Reason
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Reason"));
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
                public Locations.FieldsClass InventoryLocation
                {
                    get
                    {
                        return new Locations.FieldsClass(GetNestedName("InventoryLocation"));
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
