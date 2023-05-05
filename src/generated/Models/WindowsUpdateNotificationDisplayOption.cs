using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Windows Update Notification Display Options</summary>
    public enum WindowsUpdateNotificationDisplayOption {
        /// <summary>Not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Use the default Windows Update notifications.</summary>
        [EnumMember(Value = "defaultNotifications")]
        DefaultNotifications,
        /// <summary>Turn off all notifications, excluding restart warnings.</summary>
        [EnumMember(Value = "restartWarningsOnly")]
        RestartWarningsOnly,
        /// <summary>Turn off all notifications, including restart warnings.</summary>
        [EnumMember(Value = "disableAllNotifications")]
        DisableAllNotifications,
        /// <summary>Evolvable enum member</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
