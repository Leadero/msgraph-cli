// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.CallRecords {
    public class ServiceUserAgent : UserAgent, IParsable {
        /// <summary>The role property</summary>
        public ServiceRole? Role { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ServiceUserAgent"/> and sets the default values.
        /// </summary>
        public ServiceUserAgent() : base() {
            OdataType = "#microsoft.graph.callRecords.serviceUserAgent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="ServiceUserAgent"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ServiceUserAgent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceUserAgent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"role", n => { Role = n.GetEnumValue<ServiceRole>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ServiceRole>("role", Role);
        }
    }
}
