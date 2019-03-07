using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblBOMs")]
        public class BOMs : XPLiteObject
        {
            private int fBOMID;
            [Key(true)]
            public int BOMID
            {
                get => fBOMID;
                set => SetPropertyValue<int>("BOMID", ref fBOMID, value);
            }
            private Items fBOMRawMatID;
            public Items BOMRawMatID
            {
                get => fBOMRawMatID;
                set => SetPropertyValue("BOMRawMatID", ref fBOMRawMatID, value);
            }
            private Items fBOMFiniGoodID;
            [Association("Item-BOM")]
            public Items BOMFiniGoodID
            {
                get => fBOMFiniGoodID;
                set => SetPropertyValue("BOMFiniGoodID", ref fBOMFiniGoodID, value);
            }
            private float fBOMQuantity;
            public float BOMQuantity
            {
                get => fBOMQuantity;
                set => SetPropertyValue("BOMQuantity", ref fBOMQuantity, value);
            }
            private double fScrapFactor;
            public double ScrapFactor
            {
                get => fScrapFactor;
                set => SetPropertyValue("ScrapFactor", ref fScrapFactor, value);
            }
            public BOMs(Session session) : base(session)
            {
            }
            public BOMs() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }
            private static FieldsClass _Fields;
            public static new FieldsClass Fields
            {
                get
                {
                    if (ReferenceEquals(_Fields, null))
                        _Fields = new FieldsClass();
                    return _Fields;
                }
            }
            // Created/Updated: Joel-PC\Joel on JOEL-PC at 28/03/2012 11:55 PM
            public new class FieldsClass : PersistentBase.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }

                public OperandProperty BOMID => new OperandProperty(GetNestedName("BOMID"));
                public Items.FieldsClass BOMRawMatID => new Items.FieldsClass(GetNestedName("BOMRawMatID"));
                public Items.FieldsClass BOMFiniGoodID => new Items.FieldsClass(GetNestedName("BOMFiniGoodID"));
                public OperandProperty BOMQuantity => new OperandProperty(GetNestedName("BOMQuantity"));
                public OperandProperty ScrapFactor => new OperandProperty(GetNestedName("ScrapFactor"));
            }
        }
    }
}
