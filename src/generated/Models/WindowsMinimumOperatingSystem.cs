// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The minimum operating system required for a Windows mobile app.
    /// </summary>
    public class WindowsMinimumOperatingSystem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Windows version 10.0 or later.</summary>
        public bool? V100 { get; set; }
        /// <summary>Windows version 8.0 or later.</summary>
        public bool? V80 { get; set; }
        /// <summary>Windows version 8.1 or later.</summary>
        public bool? V81 { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WindowsMinimumOperatingSystem"/> and sets the default values.
        /// </summary>
        public WindowsMinimumOperatingSystem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="WindowsMinimumOperatingSystem"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WindowsMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsMinimumOperatingSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"v10_0", n => { V100 = n.GetBoolValue(); } },
                {"v8_0", n => { V80 = n.GetBoolValue(); } },
                {"v8_1", n => { V81 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("v10_0", V100);
            writer.WriteBoolValue("v8_0", V80);
            writer.WriteBoolValue("v8_1", V81);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
