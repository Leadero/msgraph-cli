using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Indicates the type of return code.</summary>
    public enum Win32LobAppReturnCodeType {
        /// <summary>Failed.</summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>Success.</summary>
        [EnumMember(Value = "success")]
        Success,
        /// <summary>Soft-reboot is required.</summary>
        [EnumMember(Value = "softReboot")]
        SoftReboot,
        /// <summary>Hard-reboot is required.</summary>
        [EnumMember(Value = "hardReboot")]
        HardReboot,
        /// <summary>Retry.</summary>
        [EnumMember(Value = "retry")]
        Retry,
    }
}
