using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SigninFrequencyType {
        [EnumMember(Value = "days")]
        Days,
        [EnumMember(Value = "hours")]
        Hours,
    }
}
