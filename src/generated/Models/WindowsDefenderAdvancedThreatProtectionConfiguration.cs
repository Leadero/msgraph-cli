// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Windows Defender AdvancedThreatProtection Configuration.
    /// </summary>
    public class WindowsDefenderAdvancedThreatProtectionConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Windows Defender AdvancedThreatProtection &apos;Allow Sample Sharing&apos; Rule</summary>
        public bool? AllowSampleSharing { get; set; }
        /// <summary>Expedite Windows Defender Advanced Threat Protection telemetry reporting frequency.</summary>
        public bool? EnableExpeditedTelemetryReporting { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WindowsDefenderAdvancedThreatProtectionConfiguration"/> and sets the default values.
        /// </summary>
        public WindowsDefenderAdvancedThreatProtectionConfiguration() : base() {
            OdataType = "#microsoft.graph.windowsDefenderAdvancedThreatProtectionConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="WindowsDefenderAdvancedThreatProtectionConfiguration"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsDefenderAdvancedThreatProtectionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDefenderAdvancedThreatProtectionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowSampleSharing", n => { AllowSampleSharing = n.GetBoolValue(); } },
                {"enableExpeditedTelemetryReporting", n => { EnableExpeditedTelemetryReporting = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowSampleSharing", AllowSampleSharing);
            writer.WriteBoolValue("enableExpeditedTelemetryReporting", EnableExpeditedTelemetryReporting);
        }
    }
}
