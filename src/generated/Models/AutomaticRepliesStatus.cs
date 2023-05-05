using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AutomaticRepliesStatus {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "alwaysEnabled")]
        AlwaysEnabled,
        [EnumMember(Value = "scheduled")]
        Scheduled,
    }
}
