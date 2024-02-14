// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Contains properties and inherited properties for Android store apps.
    /// </summary>
    public class AndroidStoreApp : MobileApp, IParsable {
        /// <summary>The Android app store URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppStoreUrl { get; set; }
#nullable restore
#else
        public string AppStoreUrl { get; set; }
#endif
        /// <summary>The value for the minimum applicable operating system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidMinimumOperatingSystem? MinimumSupportedOperatingSystem { get; set; }
#nullable restore
#else
        public AndroidMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
#endif
        /// <summary>The package identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackageId { get; set; }
#nullable restore
#else
        public string PackageId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AndroidStoreApp"/> and sets the default values.
        /// </summary>
        public AndroidStoreApp() : base() {
            OdataType = "#microsoft.graph.androidStoreApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="AndroidStoreApp"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidStoreApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidStoreApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appStoreUrl", n => { AppStoreUrl = n.GetStringValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<AndroidMinimumOperatingSystem>(AndroidMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                {"packageId", n => { PackageId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appStoreUrl", AppStoreUrl);
            writer.WriteObjectValue<AndroidMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("packageId", PackageId);
        }
    }
}
