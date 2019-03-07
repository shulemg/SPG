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
                get => fFromLocation;
                set => SetPropertyValue("FromLocation", ref fFromLocation, value);
            }

            private Locations fToLocation;
            [Association("Location-TransfersTo")]
            public Locations ToLocation
            {
                get => fToLocation;
                set => SetPropertyValue("ToLocation", ref fToLocation, value);
            }

            private DateTime fTransferDate;
            public DateTime TransferDate
            {
                get => fTransferDate;
                set => SetPropertyValue<DateTime>("TransferDate", ref fTransferDate, value);
            }

            private Carriers fTransferCarrier;
            public Carriers TransferCarrier
            {
                get => fTransferCarrier;
                set => SetPropertyValue("TransferCarrier", ref fTransferCarrier, value);
            }

            private string fTrailer;
            [Size(50)]
            public string Trailer
            {
                get => fTrailer;
                set => SetPropertyValue("Trailer", ref fTrailer, value);
            }

            private int fTransferNumber;
            public int TransferNumber
            {
                get => fTransferNumber;
                set => SetPropertyValue<int>("TransferNumber", ref fTransferNumber, value);
            }

            private Employees fLoadedBy;
            [Association("Employee-LoadedTransfer")]
            public Employees LoadedBy
            {
                get => fLoadedBy;
                set => SetPropertyValue("LoadedBy", ref fLoadedBy, value);
            }

            private Employees fUnloadedBy;
            [Association("Employee-UnloadedTransfer")]
            public Employees UnloadedBy
            {
                get => fUnloadedBy;
                set => SetPropertyValue("UnloadedBy", ref fUnloadedBy, value);
            }

            private Employees fCheckedBy;
            [Association("Employee-CheckedTransfer")]
            public Employees CheckedBy
            {
                get => fCheckedBy;
                set => SetPropertyValue("CheckedBy", ref fCheckedBy, value);
            }

            [Association("Transfer-Details", typeof(LocationTransferDetails))]
            [Aggregated()]
            public XPCollection<LocationTransferDetails> TransferDetails => GetCollection<LocationTransferDetails>("TransferDetails");

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

            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty Oid => new OperandProperty(GetNestedName("Oid"));
                public Locations.FieldsClass FromLocation => new Locations.FieldsClass(GetNestedName("FromLocation"));
                public Locations.FieldsClass ToLocation => new Locations.FieldsClass(GetNestedName("ToLocation"));
                public OperandProperty TransferDate => new OperandProperty(GetNestedName("TransferDate"));
                public Carriers.FieldsClass TransferCarrier => new Carriers.FieldsClass(GetNestedName("TransferCarrier"));
                public OperandProperty Trailer => new OperandProperty(GetNestedName("Trailer"));
                public OperandProperty TransferNumber => new OperandProperty(GetNestedName("TransferNumber"));
                public XPObject.FieldsClass LoadedBy => new XPObject.FieldsClass(GetNestedName("LoadedBy"));
                public XPObject.FieldsClass UnloadedBy => new XPObject.FieldsClass(GetNestedName("UnloadedBy"));
                public XPObject.FieldsClass CheckedBy => new XPObject.FieldsClass(GetNestedName("CheckedBy"));
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
