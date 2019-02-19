namespace DXDAL
{
    namespace My
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated()]
        [global::System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal sealed partial class MySettings : global::System.Configuration.ApplicationSettingsBase
        {
            private static MySettings defaultInstance = (MySettings)global::System.Configuration.ApplicationSettingsBase.Synchronized(new MySettings());

            /* TODO ERROR: Skipped IfDirectiveTrivia *//* TODO ERROR: Skipped DisabledTextTrivia *//* TODO ERROR: Skipped EndIfDirectiveTrivia */
            public static MySettings Default
            {
                get
                {

                    /* TODO ERROR: Skipped IfDirectiveTrivia *//* TODO ERROR: Skipped DisabledTextTrivia *//* TODO ERROR: Skipped EndIfDirectiveTrivia */
                    return defaultInstance;
                }
            }

            [global::System.Configuration.ApplicationScopedSetting()]
            [global::System.Diagnostics.DebuggerNonUserCode()]
            [global::System.Configuration.SpecialSetting(global::System.Configuration.SpecialSetting.ConnectionString)]
            [global::System.Configuration.DefaultSettingValue(@"Data Source=.\;Initial Catalog=SPGData;Integrated Security=True")]
            public string SPGDataConnectionString
            {
                get
                {
                    return System.Convert.ToString(this["SPGDataConnectionString"]);
                }
            }

            [global::System.Configuration.ApplicationScopedSetting()]
            [global::System.Diagnostics.DebuggerNonUserCode()]
            [global::System.Configuration.SpecialSetting(global::System.Configuration.SpecialSetting.ConnectionString)]
            [global::System.Configuration.DefaultSettingValue("Data Source=.;Initial Catalog=SPGData;Integrated Security=True")]
            public string SPGDataConnectionString1
            {
                get
                {
                    return System.Convert.ToString(this["SPGDataConnectionString1"]);
                }
            }
        }
    }

    namespace My
    {
        [global::System.Diagnostics.DebuggerNonUserCode()]
        [global::System.Runtime.CompilerServices.CompilerGenerated()]
        internal static class MySettingsProperty
        {
            [global::System.ComponentModel.Design.HelpKeyword("My.Settings")]
            internal static global::DXDAL.My.MySettings Settings
            {
                get
                {
                    return global::DXDAL.My.MySettings.Default;
                }
            }
        }
    }
}
