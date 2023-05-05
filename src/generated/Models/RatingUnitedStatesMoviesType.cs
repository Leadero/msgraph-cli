using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Movies rating labels in United States</summary>
    public enum RatingUnitedStatesMoviesType {
        /// <summary>Default value, allow all movies content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any movies content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>G, all ages admitted</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>PG, some material may not be suitable for children</summary>
        [EnumMember(Value = "parentalGuidance")]
        ParentalGuidance,
        /// <summary>PG13, some material may be inappropriate for children under 13</summary>
        [EnumMember(Value = "parentalGuidance13")]
        ParentalGuidance13,
        /// <summary>R, viewers under 17 require accompanying parent or adult guardian</summary>
        [EnumMember(Value = "restricted")]
        Restricted,
        /// <summary>NC17, adults only</summary>
        [EnumMember(Value = "adults")]
        Adults,
    }
}
