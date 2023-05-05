using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Allow the device to send diagnostic and usage telemetry data, such as Watson.</summary>
    public enum DiagnosticDataSubmissionMode {
        /// <summary>Allow the user to set.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>No telemetry data is sent from OS components. Note: This value is only applicable to enterprise and server devices. Using this setting on other devices is equivalent to setting the value of 1.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Sends basic telemetry data.</summary>
        [EnumMember(Value = "basic")]
        Basic,
        /// <summary>Sends enhanced telemetry data including usage and insights data.</summary>
        [EnumMember(Value = "enhanced")]
        Enhanced,
        /// <summary>Sends full telemetry data including diagnostic data, such as system state.</summary>
        [EnumMember(Value = "full")]
        Full,
    }
}
