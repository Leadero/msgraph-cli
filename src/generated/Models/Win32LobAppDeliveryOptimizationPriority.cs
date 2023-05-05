using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Contains value for delivery optimization priority.</summary>
    public enum Win32LobAppDeliveryOptimizationPriority {
        /// <summary>Not configured or background normal delivery optimization priority.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Foreground delivery optimization priority.</summary>
        [EnumMember(Value = "foreground")]
        Foreground,
    }
}
