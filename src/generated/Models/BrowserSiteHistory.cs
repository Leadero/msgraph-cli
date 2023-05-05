using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The history for the site modifications
    /// </summary>
    public class BrowserSiteHistory : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Controls the behavior of redirected sites. If true, indicates that the site will open in Internet Explorer 11 or Microsoft Edge even if the site is navigated to as part of a HTTP or meta refresh redirection chain.</summary>
        public bool? AllowRedirect { get; set; }
        /// <summary>The comment for the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>Controls what compatibility setting is used for specific sites or domains. The possible values are: default, internetExplorer8Enterprise, internetExplorer7Enterprise, internetExplorer11, internetExplorer10, internetExplorer9, internetExplorer8, internetExplorer7, internetExplorer5, unknownFutureValue.</summary>
        public BrowserSiteCompatibilityMode? CompatibilityMode { get; set; }
        /// <summary>The user who last modified the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy { get; set; }
#nullable restore
#else
        public IdentitySet LastModifiedBy { get; set; }
#endif
        /// <summary>The merge type of the site. The possible values are: noMerge, default, unknownFutureValue.</summary>
        public BrowserSiteMergeType? MergeType { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The date and time when the site was last published.</summary>
        public DateTimeOffset? PublishedDateTime { get; set; }
        /// <summary>The target environment that the site should open in. The possible values are: internetExplorerMode, internetExplorer11, microsoftEdge, configurable, none, unknownFutureValue.Prior to June 15, 2022, the internetExplorer11 option would allow opening a site in the Internet Explorer 11 (IE11) desktop application. Following the retirement of IE11 on June 15, 2022, the internetExplorer11 option will no longer open an IE11 window and will instead behave the same as the internetExplorerMode option.</summary>
        public BrowserSiteTargetEnvironment? TargetEnvironment { get; set; }
        /// <summary>
        /// Instantiates a new browserSiteHistory and sets the default values.
        /// </summary>
        public BrowserSiteHistory() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BrowserSiteHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BrowserSiteHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowRedirect", n => { AllowRedirect = n.GetBoolValue(); } },
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"compatibilityMode", n => { CompatibilityMode = n.GetEnumValue<BrowserSiteCompatibilityMode>(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"mergeType", n => { MergeType = n.GetEnumValue<BrowserSiteMergeType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"publishedDateTime", n => { PublishedDateTime = n.GetDateTimeOffsetValue(); } },
                {"targetEnvironment", n => { TargetEnvironment = n.GetEnumValue<BrowserSiteTargetEnvironment>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowRedirect", AllowRedirect);
            writer.WriteStringValue("comment", Comment);
            writer.WriteEnumValue<BrowserSiteCompatibilityMode>("compatibilityMode", CompatibilityMode);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteEnumValue<BrowserSiteMergeType>("mergeType", MergeType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("publishedDateTime", PublishedDateTime);
            writer.WriteEnumValue<BrowserSiteTargetEnvironment>("targetEnvironment", TargetEnvironment);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
