using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>A managed (MAM) application&apos;s availability.</summary>
    public enum ManagedAppAvailability {
        /// <summary>A globally available app to all tenants.</summary>
        [EnumMember(Value = "global")]
        Global,
        /// <summary>A line of business apps private to an organization.</summary>
        [EnumMember(Value = "lineOfBusiness")]
        LineOfBusiness,
    }
}
