﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QO_100_WB_Quick_Tune.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9750000")]
        public string lnb_offset {
            get {
                return ((string)(this["lnb_offset"]));
            }
            set {
                this["lnb_offset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("232.0.0.11")]
        public string mt_ip {
            get {
                return ((string)(this["mt_ip"]));
            }
            set {
                this["mt_ip"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6789")]
        public string mt_port {
            get {
                return ((string)(this["mt_port"]));
            }
            set {
                this["mt_port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>232.0.0.11,6789,9750000</string>
  <string>232.0.0.11,6790,9750000</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ReceiverList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ReceiverList"]));
            }
            set {
                this["ReceiverList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double Opacity {
            get {
                return ((double)(this["Opacity"]));
            }
            set {
                this["Opacity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Minimal {
            get {
                return ((bool)(this["Minimal"]));
            }
            set {
                this["Minimal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point Location {
            get {
                return ((global::System.Drawing.Point)(this["Location"]));
            }
            set {
                this["Location"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int scan_dwell {
            get {
                return ((int)(this["scan_dwell"]));
            }
            set {
                this["scan_dwell"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int scan_minsr {
            get {
                return ((int)(this["scan_minsr"]));
            }
            set {
                this["scan_minsr"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int scan_numrx {
            get {
                return ((int)(this["scan_numrx"]));
            }
            set {
                this["scan_numrx"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("232.0.0.1")]
        public string wh_ip {
            get {
                return ((string)(this["wh_ip"]));
            }
            set {
                this["wh_ip"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9910")]
        public string wh_port {
            get {
                return ((string)(this["wh_port"]));
            }
            set {
                this["wh_port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9750000")]
        public string wh_lo {
            get {
                return ((string)(this["wh_lo"]));
            }
            set {
                this["wh_lo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool wh_scan_checked {
            get {
                return ((bool)(this["wh_scan_checked"]));
            }
            set {
                this["wh_scan_checked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool avoidbeacon {
            get {
                return ((bool)(this["avoidbeacon"]));
            }
            set {
                this["avoidbeacon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int mode {
            get {
                return ((int)(this["mode"]));
            }
            set {
                this["mode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("wss://eshail.batc.org.uk/wb/fft")]
        public string fft_url {
            get {
                return ((string)(this["fft_url"]));
            }
            set {
                this["fft_url"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string chat_nick {
            get {
                return ((string)(this["chat_nick"]));
            }
            set {
                this["chat_nick"] = value;
            }
        }
    }
}
