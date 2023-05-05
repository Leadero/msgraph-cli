using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Allows IT admind to set a predefined default search engine for MDM-Controlled devices</summary>
    public enum EdgeSearchEngineType {
        /// <summary>Uses factory settings of Edge to assign the default search engine as per the user market</summary>
        [EnumMember(Value = "default")]
        Default,
        /// <summary>Sets Bing as the default search engine</summary>
        [EnumMember(Value = "bing")]
        Bing,
    }
}
