using DevExpress.Xpo;

namespace DXDAL
{
    namespace SPGData
    {
        [Persistent("tblVersion")]
        public partial class LatestVersion : XPObject
        {
            public LatestVersion(Session session) : base(session)
            {
            }
            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }
            // Dim fID As Integer
            // <Key(True)>
            // Public Property ID() As Integer
            // Get
            // Return fID
            // End Get
            // Set(ByVal value As Integer)
            // SetPropertyValue(Of Integer)("ID", fID, value)
            // End Set
            // End Property
            private int fLatestRevision;
            public int LatestRevision
            {
                get
                {
                    return fLatestRevision;
                }
                set
                {
                    SetPropertyValue<int>("LatestRevision", ref fLatestRevision, value);
                }
            }
        }
    }
}
