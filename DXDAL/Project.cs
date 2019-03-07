using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class Project : AuditableBase
        {
            private DateTime? _actualStartDate;
            private DateTime? _scheduledDate;
            private string _scheduledWeek;
            private ProjectStatus _projectStatus;
            private DateTime? _requestedDeliveryDate;
            private DateTime? _requestedShippingDate;
            private DateTime? _requestedStartDate;
            private string _notes;
            private Customers _customer;
            private string _project;

            public string project
            {
                get => _project;
                set => SetPropertyValue("project", ref _project, value);
            }

            [Association("Customer-Projects")]
            public Customers Customer
            {
                get => _customer;
                set => SetPropertyValue("Customer", ref _customer, value);
            }

            public string Notes
            {
                get => _notes;
                set => SetPropertyValue("Notes", ref _notes, value);
            }

            public DateTime? RequestedStartDate
            {
                get => _requestedStartDate;
                set => SetPropertyValue("RequestedStartDate", ref _requestedStartDate, value);
            }

            public DateTime? RequestedShippingDate
            {
                get => _requestedShippingDate;
                set => SetPropertyValue("RequestedShippingDate", ref _requestedShippingDate, value);
            }

            public DateTime? RequestedDeliveryDate
            {
                get => _requestedDeliveryDate;
                set => SetPropertyValue("RequestedDeliveryDate", ref _requestedDeliveryDate, value);
            }

            public ProjectStatus ProjectStatus
            {
                get
                {
                    if (_projectStatus != ProjectStatus.Completed)
                    {
                        if (System.Convert.ToInt32(Evaluate("ProjectDetails.Sum(UnitsNeeded)")) != System.Convert.ToInt32(Evaluate("ProjectDetails.Sum(UnitsRequested)")))
                            return ProjectStatus.Started;
                        if (System.Convert.ToInt32(Evaluate("ProjectDetails.Sum(UnitsNeededToSchedule)")) <= 0)
                            return ProjectStatus.Scheduled;
                        return ProjectStatus.Open;
                    }

                    return _projectStatus;
                }
                set => SetPropertyValue("ProjectStatus", ref _projectStatus, value);
            }

            public DateTime? ScheduledDate
            {
                get => _scheduledDate;
                set => SetPropertyValue("ScheduledDate", ref _scheduledDate, value);
            }

            public string ScheduledWeek
            {
                get => _scheduledWeek;
                set => SetPropertyValue("ScheduledWeek", ref _scheduledWeek, value);
            }

            public DateTime? ActualStartDate
            {
                get => _actualStartDate;
                set => SetPropertyValue("ActualStartDate", ref _actualStartDate, value);
            }

            [Association("Project-Details", typeof(ProjectDetails))]
            [Aggregated()]
            public XPCollection<ProjectDetails> ProjectDetails => GetCollection<ProjectDetails>("ProjectDetails");

            public Project() : base()
            {
            }

            public Project(Session session) : base(session)
            {
            }

            public override void AfterConstruction()
            {
                base.AfterConstruction();
            }

            public override string ToString()
            {
                return string.Format("{0} - {1}", Oid, project);
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
                public OperandProperty project => new OperandProperty(GetNestedName("project"));
                public Customers.FieldsClass Customer => new Customers.FieldsClass(GetNestedName("Customer"));
                public OperandProperty Notes => new OperandProperty(GetNestedName("Notes"));
                public OperandProperty RequestedStartDate => new OperandProperty(GetNestedName("RequestedStartDate"));
                public OperandProperty RequestedShippingDate => new OperandProperty(GetNestedName("RequestedShippingDate"));
                public OperandProperty RequestedDeliveryDate => new OperandProperty(GetNestedName("RequestedDeliveryDate"));
                public OperandProperty ProjectStatus => new OperandProperty(GetNestedName("ProjectStatus"));
                public OperandProperty ScheduledWeek => new OperandProperty(GetNestedName("ScheduledWeek"));
                public OperandProperty ScheduledDate => new OperandProperty(GetNestedName("ScheduledDate"));
                public OperandProperty ActualStartDate => new OperandProperty(GetNestedName("ActualStartDate"));
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
