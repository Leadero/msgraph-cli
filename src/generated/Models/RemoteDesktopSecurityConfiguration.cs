// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class RemoteDesktopSecurityConfiguration : Entity, IParsable {
        /// <summary>Determines if Microsoft Entra ID RDS authentication protocol for RDP is enabled.</summary>
        public bool? IsRemoteDesktopProtocolEnabled { get; set; }
        /// <summary>The collection of target device groups that are associated with the RDS security configuration that will be enabled for SSO when a client connects to the target device over RDP using the new Microsoft Entra ID RDS authentication protocol.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TargetDeviceGroup>? TargetDeviceGroups { get; set; }
#nullable restore
#else
        public List<TargetDeviceGroup> TargetDeviceGroups { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="RemoteDesktopSecurityConfiguration"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RemoteDesktopSecurityConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoteDesktopSecurityConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isRemoteDesktopProtocolEnabled", n => { IsRemoteDesktopProtocolEnabled = n.GetBoolValue(); } },
                {"targetDeviceGroups", n => { TargetDeviceGroups = n.GetCollectionOfObjectValues<TargetDeviceGroup>(TargetDeviceGroup.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isRemoteDesktopProtocolEnabled", IsRemoteDesktopProtocolEnabled);
            writer.WriteCollectionOfObjectValues<TargetDeviceGroup>("targetDeviceGroups", TargetDeviceGroups);
        }
    }
}
