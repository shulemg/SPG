using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace DXDAL
{
    namespace SPGData
    {
        public class BreakTime : XPObject
        {
            public BreakTime(Session session) : base(session)
            {
            }


            private DayOfWeek m_WeekDay;
            public DayOfWeek WeekDay
            {
                get => m_WeekDay;
                set => SetPropertyValue("WeekDay", ref m_WeekDay, value);
            }

            private DateTime m_StartTime;
            public DateTime StartTime
            {
                get => m_StartTime;
                set => SetPropertyValue<DateTime>("StartTime", ref m_StartTime, value);
            }

            private DateTime m_EndTime;
            public DateTime EndTime
            {
                get => m_EndTime;
                set => SetPropertyValue<DateTime>("EndTime", ref m_EndTime, value);
            }

            private DateTime m_Starting;
            public DateTime Starting
            {
                get => m_Starting;
                set => SetPropertyValue<DateTime>("Starting", ref m_Starting, value);
            }

            private DateTime m_Ending;
            public DateTime Ending
            {
                get => m_Ending;
                set => SetPropertyValue<DateTime>("Ending", ref m_Ending, value);
            }









            public new class FieldsClass : XPObject.FieldsClass
            {
                public FieldsClass() : base()
                {
                }
                public FieldsClass(string propertyName) : base(propertyName)
                {
                }
                public OperandProperty WeekDay => new OperandProperty(GetNestedName("WeekDay"));
                public OperandProperty StartTime => new OperandProperty(GetNestedName("StartTime"));
                public OperandProperty EndTime => new OperandProperty(GetNestedName("EndTime"));
                public OperandProperty Starting => new OperandProperty(GetNestedName("Starting"));
                public OperandProperty Ending => new OperandProperty(GetNestedName("Ending"));
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
