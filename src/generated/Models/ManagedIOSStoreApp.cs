using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ManagedIOSStoreApp : ManagedApp, IParsable {
        /// <summary>Contains properties of the possible iOS device types the mobile app can run on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosDeviceType? ApplicableDeviceType { get; set; }
#nullable restore
#else
        public IosDeviceType ApplicableDeviceType { get; set; }
#endif
        /// <summary>The Apple AppStoreUrl.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppStoreUrl { get; set; }
#nullable restore
#else
        public string AppStoreUrl { get; set; }
#endif
        /// <summary>The app&apos;s Bundle ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BundleId { get; set; }
#nullable restore
#else
        public string BundleId { get; set; }
#endif
        /// <summary>Contains properties of the minimum operating system required for an iOS mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosMinimumOperatingSystem? MinimumSupportedOperatingSystem { get; set; }
#nullable restore
#else
        public IosMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ManagedIOSStoreApp and sets the default values.
        /// </summary>
        public ManagedIOSStoreApp() : base() {
            OdataType = "#microsoft.graph.managedIOSStoreApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedIOSStoreApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedIOSStoreApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableDeviceType", n => { ApplicableDeviceType = n.GetObjectValue<IosDeviceType>(IosDeviceType.CreateFromDiscriminatorValue); } },
                {"appStoreUrl", n => { AppStoreUrl = n.GetStringValue(); } },
                {"bundleId", n => { BundleId = n.GetStringValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<IosMinimumOperatingSystem>(IosMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IosDeviceType>("applicableDeviceType", ApplicableDeviceType);
            writer.WriteStringValue("appStoreUrl", AppStoreUrl);
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteObjectValue<IosMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
        }
    }
}
