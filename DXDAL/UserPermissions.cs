using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblUserPermissions")]
        public class UserPermissions : XPLiteObject
        {
            private int fUserPermissionID;
            [Key(true)]
            public int UserPermissionID
            {
                get
                {
                    return fUserPermissionID;
                }
                set
                {
                    SetPropertyValue<int>("UserPermissionID", ref fUserPermissionID, value);
                }
            }
            private string fUserName;
            [Size(50)]
            public string UserName
            {
                get
                {
                    return fUserName;
                }
                set
                {
                    SetPropertyValue<string>("UserName", ref fUserName, value);
                }
            }
            private string fPermissionObject;
            [Size(50)]
            public string PermissionObject
            {
                get
                {
                    return fPermissionObject;
                }
                set
                {
                    SetPropertyValue<string>("PermissionObject", ref fPermissionObject, value);
                }
            }
            private string fPermissionLevel;
            [Size(50)]
            public string PermissionLevel
            {
                get
                {
                    return fPermissionLevel;
                }
                set
                {
                    SetPropertyValue<string>("PermissionLevel", ref fPermissionLevel, value);
                }
            }
            public UserPermissions(Session session) : base(session)
            {
            }
            public UserPermissions() : base(Session.DefaultSession)
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
                public OperandProperty UserPermissionID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("UserPermissionID"));
                    }
                }
                public OperandProperty UserName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("UserName"));
                    }
                }
                public OperandProperty PermissionObject
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PermissionObject"));
                    }
                }
                public OperandProperty PermissionLevel
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("PermissionLevel"));
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
