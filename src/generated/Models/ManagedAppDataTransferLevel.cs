using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Data can be transferred from/to these classes of apps</summary>
    public enum ManagedAppDataTransferLevel {
        /// <summary>All apps.</summary>
        [EnumMember(Value = "allApps")]
        AllApps,
        /// <summary>Managed apps.</summary>
        [EnumMember(Value = "managedApps")]
        ManagedApps,
        /// <summary>No apps.</summary>
        [EnumMember(Value = "none")]
        None,
    }
}
