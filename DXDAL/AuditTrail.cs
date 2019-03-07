using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblAuditTrail")]
        public class AuditTrail : XPLiteObject
        {
            private int fPK_ID;
            [Key(true)]
            public int PK_ID
            {
                get => fPK_ID;
                set => SetPropertyValue<int>("PK_ID", ref fPK_ID, value);
            }
            private string fUserID;
            [Size(50)]
            public string UserID
            {
                get => fUserID;
                set => SetPropertyValue("UserID", ref fUserID, value);
            }
            private int fRecordID;
            public int RecordID
            {
                get => fRecordID;
                set => SetPropertyValue<int>("RecordID", ref fRecordID, value);
            }
            private string fRecordType;
            [Size(50)]
            public string RecordType
            {
                get => fRecordType;
                set => SetPropertyValue("RecordType", ref fRecordType, value);
            }
            private string fRecordChanges;
            [Size(SizeAttribute.Unlimited)]
            public string RecordChanges
            {
                get => fRecordChanges;
                set => SetPropertyValue("RecordChanges", ref fRecordChanges, value);
            }
            private DateTime fChangeDate;
            public DateTime ChangeDate
            {
                get => fChangeDate;
                set => SetPropertyValue<DateTime>("ChangeDate", ref fChangeDate, value);
            }
            public AuditTrail(Session session) : base(session)
            {
            }
            public AuditTrail() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }
            // Created/Updated: Joel-PC\Joel on JOEL-PC at 3/7/2013 9:11 PM
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty PK_ID => new OperandProperty(GetNestedName("PK_ID"));
                public const string UserIDFieldName = "UserID";
                public OperandProperty UserID => new OperandProperty(GetNestedName("UserID"));
                public OperandProperty RecordID => new OperandProperty(GetNestedName("RecordID"));
                public const string RecordTypeFieldName = "RecordType";
                public OperandProperty RecordType => new OperandProperty(GetNestedName("RecordType"));
                public const string RecordChangesFieldName = "RecordChanges";
                public OperandProperty RecordChanges => new OperandProperty(GetNestedName("RecordChanges"));
                public OperandProperty ChangeDate => new OperandProperty(GetNestedName("ChangeDate"));
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
