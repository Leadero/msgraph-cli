using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>The enum to specify the channels for Microsoft Edge apps.</summary>
    public enum MicrosoftEdgeChannel {
        /// <summary>The Dev Channel is intended to help you plan and develop with the latest capabilities of Microsoft Edge.</summary>
        [EnumMember(Value = "dev")]
        Dev,
        /// <summary>The Beta Channel is intended for production deployment to a representative sample set of users. New features ship about every 4 weeks. Security and quality updates ship as needed.</summary>
        [EnumMember(Value = "beta")]
        Beta,
        /// <summary>The Stable Channel is intended for broad deployment within organizations, and it&apos;s the channel that most users should be on. New features ship about every 4 weeks. Security and quality updates ship as needed.</summary>
        [EnumMember(Value = "stable")]
        Stable,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
