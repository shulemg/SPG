Imports System.ComponentModel
Imports DevExpress.XtraEditors

<TypeConverter(GetType(ExpandableObjectConverter))>
Public Class OptionsSelection

    Public Sub New()

        DefaultLevel = ViewLevel.Days
        FirstDayOfWeek = DayOfWeek.Monday
        HighLevel = ViewLevel.Years
        LowLevel = ViewLevel.Days
        MultiSelectBehavior = SuperiorPackGroup.MultiSelectBehavior.Merging
        ShowWeekLevel = False

    End Sub

    <Description("Allow to choose the default level to be shown."), Category(CategoryName.Properties), DefaultValue(ViewLevel.Days)>
    Public Property DefaultLevel() As ViewLevel

    <Description("Allow to choose the first day of a week."), Category(CategoryName.Properties), DefaultValue(DayOfWeek.Monday)>
    Public Property FirstDayOfWeek() As DayOfWeek

    <Description("Allow to choose the highest navigation level."), Category(CategoryName.Properties), DefaultValue(ViewLevel.Years)>
    Public Property HighLevel() As ViewLevel

    <Description("Allow to choose the lowest navigation level."), Category(CategoryName.Properties), DefaultValue(ViewLevel.Days)>
    Public Property LowLevel() As ViewLevel

    <Description("Allow to chose multiselection behaviour."), Category(CategoryName.Properties), DefaultValue(MultiSelectBehavior.Merging)>
    Public Property MultiSelectBehavior() As MultiSelectBehavior

    <Description("Allow to chose whether the week level will be shown."), Category(CategoryName.Properties), DefaultValue(False)>
    Public Property ShowWeekLevel() As Boolean

End Class
