using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ThreatAssessmentStatus {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "completed")]
        Completed,
    }
}
