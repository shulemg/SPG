using System.Collections.Generic;
using System;
using DevExpress.Xpo;
using DXDAL.SPGData;

namespace DXDAL
{
    [NonPersistent()]
    public class AuditableBase : XPObject
    {
        protected AuditableBase()
        {
        }

        protected AuditableBase(Session session) : base(session)
        {
        }

        protected AuditableBase(Session session, DevExpress.Xpo.Metadata.XPClassInfo classInfo) : base(session, classInfo)
        {
        }

        private List<Change> changes = new List<Change>();

        private struct Change
        {
            public string PropertyName;
            public string PrevValue;
            public string Value;
        }

        public bool HasChanges => changes.Count > 0;

        private void UpdateAudit(int recordID)
        {
            if (changes.Count > 0)
            {
                AuditTrail audit = new AuditTrail(Session) { ChangeDate =DateTime.Now, RecordType = ClassInfo.ClassType.Name, UserID = Environment.UserName, RecordID = recordID };

                foreach (Change change in changes)
                    audit.RecordChanges += string.Format("{0}:{1}({2});", change.PropertyName, change.PrevValue, change.Value);
                audit.Save();
            }
        }

        protected override void OnSaved()
        {
            base.OnSaved();

            UpdateAudit(System.Convert.ToInt32(GetMemberValue("Oid")));
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            Change change = new Change() { PropertyName = propertyName };
            if (oldValue == null)
                change.PrevValue = "NULL";
            else
                change.PrevValue = oldValue.ToString();
            if (newValue == null)
                change.Value = "NULL";
            else
                change.Value = newValue.ToString();
            if (!(change.PropertyName == "Oid" && change.PrevValue == "-1") && change.PropertyName != "OptimisticLockField" && change.PropertyName != "OptimisticLockFieldInDataLayer" && change.PropertyName != "GCRecord")
                changes.Add(change);
        }

        protected override void OnDeleted()
        {
            base.OnDeleted();

            int recordID = System.Convert.ToInt32(GetPropertyValue("Oid"));

            AuditTrail audit = new AuditTrail(Session) { ChangeDate = DateTime.Now, RecordType = ClassInfo.ClassType.Name, UserID = Environment.UserName, RecordID = recordID, RecordChanges = recordID.ToString() + " was deleted" };

            audit.Save();
        }
    }
}
