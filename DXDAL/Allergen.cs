using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblAllergen")]
        public class Allergen : XPLiteObject
        {
            private int fAllergenID;
            [Key(true)]
            public int AllergenID
            {
                get
                {
                    return fAllergenID;
                }
                set
                {
                    SetPropertyValue<int>("AllergenID", ref fAllergenID, value);
                }
            }
            private string fAllergenName;
            [Size(50)]
            public string AllergenName
            {
                get
                {
                    return fAllergenName;
                }
                set
                {
                    SetPropertyValue<string>("AllergenName", ref fAllergenName, value);
                }
            }

            public Allergen(Session session) : base(session)
            {
            }
            public Allergen() : base(Session.DefaultSession)
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
                public OperandProperty AllergenID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("AllergenID"));
                    }
                }
                public OperandProperty AllergenName
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("AllergenName"));
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
