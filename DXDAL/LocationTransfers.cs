using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class LocationTransfers : AuditableBase
        {
            private Locations fFromLocation;
            [Association("Location-TransfersFrom")]
            public Locations FromLocation
            {
                get
                {
                    return fFromLocation;
                }
                set
                {
                    SetPropertyValue<Locations>("FromLocation", ref fFromLocation, value);
                }
            }

            private Locations fToLocation;
            [Association("Location-TransfersTo")]
            public Locations ToLocation
            {
                get
                {
                    return fToLocation;
                }
                set
                {
                    SetPropertyValue<Locations>("ToLocation", ref fToLocation, value);
                }
            }

            private DateTime fTransferDate;
            public DateTime TransferDate
            {
                get
                {
                    return fTransferDate;
                }
                set
                {
                    SetPropertyValue<DateTime>("TransferDate", ref fTransferDate, value);
                }
            }

            private Carriers fTransferCarrier;
            public Carriers TransferCarrier
            {
                get
                {
                    return fTransferCarrier;
                }
                set
                {
                    SetPropertyValue<Carriers>("TransferCarrier", ref fTransferCarrier, value);
                }
            }

            private string fTrailer;
            [Size(50)]
            public string Trailer
            {
                get
                {
                    return fTrailer;
                }
                set
                {
                    SetPropertyValue<string>("Trailer", ref fTrailer, value);
                }
            }

            private int fTransferNumber;
            public int TransferNumber
            {
                get
                {
                    return fTransferNumber;
                }
                set
                {
                    SetPropertyValue<int>("TransferNumber", ref fTransferNumber, value);
                }
            }

            private Employees fLoadedBy;
            [Association("Employee-LoadedTransfer")]
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

            private Employees fUnloadedBy;
            [Association("Employee-UnloadedTransfer")]
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
            [Association("Employee-CheckedTransfer")]
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

            [Association("Transfer-Details", typeof(LocationTransferDetails))]
            [Aggregated()]
            public XPCollection<LocationTransferDetails> TransferDetails
            {
                get
                {
                    return GetCollection<LocationTransferDetails>("TransferDetails");
                }
            }

            public LocationTransfers() : base()
            {
            }

            public LocationTransfers(Session session) : base(session)
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
                public OperandProperty Oid
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Oid"));
                    }
                }
                public Locations.FieldsClass FromLocation
                {
                    get
                    {
                        return new Locations.FieldsClass(GetNestedName("FromLocation"));
                    }
                }
                public Locations.FieldsClass ToLocation
                {
                    get
                    {
                        return new Locations.FieldsClass(GetNestedName("ToLocation"));
                    }
                }
                public OperandProperty TransferDate
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("TransferDate"));
                    }
                }
                public Carriers.FieldsClass TransferCarrier
                {
                    get
                    {
                        return new Carriers.FieldsClass(GetNestedName("TransferCarrier"));
                    }
                }
                public OperandProperty Trailer
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("Trailer"));
                    }
                }
                public OperandProperty TransferNumber
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("TransferNumber"));
                    }
                }
                public Employees.FieldsClass LoadedBy
                {
                    get
                    {
                        return new Employees.FieldsClass(GetNestedName("LoadedBy"));
                    }
                }
                public Employees.FieldsClass UnloadedBy
                {
                    get
                    {
                        return new Employees.FieldsClass(GetNestedName("UnloadedBy"));
                    }
                }
                public Employees.FieldsClass CheckedBy
                {
                    get
                    {
                        return new Employees.FieldsClass(GetNestedName("CheckedBy"));
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
