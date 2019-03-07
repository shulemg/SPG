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
                get => fAdjustmentID;
                set => SetPropertyValue<int>("AdjustmentID", ref fAdjustmentID, value);
            }
            private DateTime fAdjustmentDate;
            public DateTime AdjustmentDate
            {
                get => fAdjustmentDate;
                set => SetPropertyValue<DateTime>("AdjustmentDate", ref fAdjustmentDate, value);
            }
            private Customers fCustomer;
            public Customers Customer
            {
                get => fCustomer;
                set => SetPropertyValue("Customer", ref fCustomer, value);
            }
            private Items fItem;
            [Persistent("Item")]
            public Items AdjustmentItem
            {
                get => fItem;
                set => SetPropertyValue("AdjustmentItem", ref fItem, value);
            }
            private float fOriginalQuantity;
            public float OriginalQuantity
            {
                get => fOriginalQuantity;
                set => SetPropertyValue("OriginalQuantity", ref fOriginalQuantity, value);
            }
            private float? fNewCount;
            public float? NewCount
            {
                get => fNewCount;
                set => SetPropertyValue("NewCount", ref fNewCount, value);
            }
            private string fOriginalLot;
            public string OriginalLot
            {
                get => fOriginalLot;
                set => SetPropertyValue("OriginalLot", ref fOriginalLot, value);
            }
            private string fNewLot;
            public string NewLot
            {
                get => fNewLot;
                set => SetPropertyValue("NewLot", ref fNewLot, value);
            }
            private int? fLPN;
            public int? LPN
            {
                get => fLPN;
                set => SetPropertyValue("LPN", ref fLPN, value);
            }
            private string fReason;
            [Size(150)]
            public string Reason
            {
                get => fReason;
                set => SetPropertyValue("Reason", ref fReason, value);
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
            private Locations fInventoryLocation;
            public Locations InventoryLocation
            {
                get => fInventoryLocation;
                set => SetPropertyValue("InventoryLocation", ref fInventoryLocation, value);
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
                public OperandProperty AdjustmentID => new OperandProperty(GetNestedName("AdjustmentID"));
                public OperandProperty AdjustmentDate => new OperandProperty(GetNestedName("AdjustmentDate"));
                public Customers.FieldsClass Customer => new Customers.FieldsClass(GetNestedName("Customer"));
                public Items.FieldsClass AdjustmentItem => new Items.FieldsClass(GetNestedName("AdjustmentItem"));
                public OperandProperty OriginalQuantity => new OperandProperty(GetNestedName("OriginalQuantity"));
                public OperandProperty NewCount => new OperandProperty(GetNestedName("NewCount"));
                public OperandProperty OriginalLot => new OperandProperty(GetNestedName("OriginalLot"));
                public OperandProperty NewLot => new OperandProperty(GetNestedName("NewLot"));
                public OperandProperty LPN => new OperandProperty(GetNestedName("LPN"));
                public OperandProperty Reason => new OperandProperty(GetNestedName("Reason"));
                public OperandProperty strEnteredBy => new OperandProperty(GetNestedName("strEnteredBy"));
                public OperandProperty dtmEnteredOn => new OperandProperty(GetNestedName("dtmEnteredOn"));
                public Locations.FieldsClass InventoryLocation => new Locations.FieldsClass(GetNestedName("InventoryLocation"));
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
