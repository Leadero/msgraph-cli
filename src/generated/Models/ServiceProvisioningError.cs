// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ServiceProvisioningError : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time at which the error occurred.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Indicates whether the error has been attended to.</summary>
        public bool? IsResolved { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Qualified service instance (for example, &apos;SharePoint/Dublin&apos;) that published the service error information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceInstance { get; set; }
#nullable restore
#else
        public string ServiceInstance { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ServiceProvisioningError"/> and sets the default values.
        /// </summary>
        public ServiceProvisioningError() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="ServiceProvisioningError"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ServiceProvisioningError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.serviceProvisioningXmlError" => new ServiceProvisioningXmlError(),
                _ => new ServiceProvisioningError(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"isResolved", n => { IsResolved = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"serviceInstance", n => { ServiceInstance = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteBoolValue("isResolved", IsResolved);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("serviceInstance", ServiceInstance);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
