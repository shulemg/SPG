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
                get
                {
                    return fBOMID;
                }
                set
                {
                    SetPropertyValue<int>("BOMID", ref fBOMID, value);
                }
            }
            private Items fBOMRawMatID;
            public Items BOMRawMatID
            {
                get
                {
                    return fBOMRawMatID;
                }
                set
                {
                    SetPropertyValue<Items>("BOMRawMatID", ref fBOMRawMatID, value);
                }
            }
            private Items fBOMFiniGoodID;
            [Association("Item-BOM")]
            public Items BOMFiniGoodID
            {
                get
                {
                    return fBOMFiniGoodID;
                }
                set
                {
                    SetPropertyValue<Items>("BOMFiniGoodID", ref fBOMFiniGoodID, value);
                }
            }
            private float fBOMQuantity;
            public float BOMQuantity
            {
                get
                {
                    return fBOMQuantity;
                }
                set
                {
                    SetPropertyValue<float>("BOMQuantity", ref fBOMQuantity, value);
                }
            }
            private double fScrapFactor;
            public double ScrapFactor
            {
                get
                {
                    return fScrapFactor;
                }
                set
                {
                    SetPropertyValue<double>("ScrapFactor", ref fScrapFactor, value);
                }
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
            public new class FieldsClass : DevExpress.Xpo.XPLiteObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }

                public OperandProperty BOMID
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("BOMID"));
                    }
                }
                public Items.FieldsClass BOMRawMatID
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("BOMRawMatID"));
                    }
                }
                public Items.FieldsClass BOMFiniGoodID
                {
                    get
                    {
                        return new Items.FieldsClass(GetNestedName("BOMFiniGoodID"));
                    }
                }
                public OperandProperty BOMQuantity
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("BOMQuantity"));
                    }
                }
                public OperandProperty ScrapFactor
                {
                    get
                    {
                        return new OperandProperty(GetNestedName("ScrapFactor"));
                    }
                }
            }
        }
    }
}
