using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum BrowserSharedCookieSourceEnvironment {
        /// <summary>Share session cookies from Microsoft Edge to Internet Explorer.</summary>
        [EnumMember(Value = "microsoftEdge")]
        MicrosoftEdge,
        /// <summary>Share session cookies from Internet Explorer to Microsoft Edge.</summary>
        [EnumMember(Value = "internetExplorer11")]
        InternetExplorer11,
        /// <summary>Share session cookies to and from Microsoft Edge and Internet Explorer.</summary>
        [EnumMember(Value = "both")]
        Both,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
