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
                get => fUserPermissionID;
                set => SetPropertyValue<int>("UserPermissionID", ref fUserPermissionID, value);
            }
            private string fUserName;
            [Size(50)]
            public string UserName
            {
                get => fUserName;
                set => SetPropertyValue("UserName", ref fUserName, value);
            }
            private string fPermissionObject;
            [Size(50)]
            public string PermissionObject
            {
                get => fPermissionObject;
                set => SetPropertyValue("PermissionObject", ref fPermissionObject, value);
            }
            private string fPermissionLevel;
            [Size(50)]
            public string PermissionLevel
            {
                get => fPermissionLevel;
                set => SetPropertyValue("PermissionLevel", ref fPermissionLevel, value);
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
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty UserPermissionID => new OperandProperty(GetNestedName("UserPermissionID"));
                public OperandProperty UserName => new OperandProperty(GetNestedName("UserName"));
                public OperandProperty PermissionObject => new OperandProperty(GetNestedName("PermissionObject"));
                public OperandProperty PermissionLevel => new OperandProperty(GetNestedName("PermissionLevel"));
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
