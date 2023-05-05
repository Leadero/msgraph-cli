using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Android Work Profile cross profile data sharing type.</summary>
    public enum AndroidWorkProfileCrossProfileDataSharingType {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Prevent any sharing.</summary>
        [EnumMember(Value = "preventAny")]
        PreventAny,
        /// <summary>Allow data sharing request from personal profile to work profile.</summary>
        [EnumMember(Value = "allowPersonalToWork")]
        AllowPersonalToWork,
        /// <summary>No restrictions on sharing.</summary>
        [EnumMember(Value = "noRestrictions")]
        NoRestrictions,
    }
}
