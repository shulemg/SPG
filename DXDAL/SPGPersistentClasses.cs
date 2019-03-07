using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        public class tblid : XPLiteObject
        {
            private string ftablename;
            [Key()]
            [Size(40)]
            public string tablename
            {
                get => ftablename;
                set => SetPropertyValue("tablename", ref ftablename, value);
            }
            private int fid;
            public int id
            {
                get => fid;
                set => SetPropertyValue<int>("id", ref fid, value);
            }
            public tblid(Session session) : base(session)
            {
            }
            public tblid() : base(Session.DefaultSession)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }
        }
    }
}
