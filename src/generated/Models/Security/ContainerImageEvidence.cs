// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class ContainerImageEvidence : AlertEvidence, IParsable {
        /// <summary>The digest image entity, in case this is a tag image.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContainerImageEvidence? DigestImage { get; set; }
#nullable restore
#else
        public ContainerImageEvidence DigestImage { get; set; }
#endif
        /// <summary>The unique identifier for the container image entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageId { get; set; }
#nullable restore
#else
        public string ImageId { get; set; }
#endif
        /// <summary>The container registry for this image.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContainerRegistryEvidence? Registry { get; set; }
#nullable restore
#else
        public ContainerRegistryEvidence Registry { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ContainerImageEvidence"/> and sets the default values.
        /// </summary>
        public ContainerImageEvidence() : base() {
            OdataType = "#microsoft.graph.security.containerImageEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="ContainerImageEvidence"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ContainerImageEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContainerImageEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"digestImage", n => { DigestImage = n.GetObjectValue<ContainerImageEvidence>(ContainerImageEvidence.CreateFromDiscriminatorValue); } },
                {"imageId", n => { ImageId = n.GetStringValue(); } },
                {"registry", n => { Registry = n.GetObjectValue<ContainerRegistryEvidence>(ContainerRegistryEvidence.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ContainerImageEvidence>("digestImage", DigestImage);
            writer.WriteStringValue("imageId", ImageId);
            writer.WriteObjectValue<ContainerRegistryEvidence>("registry", Registry);
        }
    }
}
