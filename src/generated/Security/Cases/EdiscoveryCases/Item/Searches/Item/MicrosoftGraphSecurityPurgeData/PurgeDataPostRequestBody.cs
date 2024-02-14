// <auto-generated/>
using ApiSdk.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Security.Cases.EdiscoveryCases.Item.Searches.Item.MicrosoftGraphSecurityPurgeData {
    public class PurgeDataPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The purgeAreas property</summary>
        public ApiSdk.Models.Security.PurgeAreas? PurgeAreas { get; set; }
        /// <summary>The purgeType property</summary>
        public ApiSdk.Models.Security.PurgeType? PurgeType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="PurgeDataPostRequestBody"/> and sets the default values.
        /// </summary>
        public PurgeDataPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="PurgeDataPostRequestBody"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PurgeDataPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PurgeDataPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"purgeAreas", n => { PurgeAreas = n.GetEnumValue<PurgeAreas>(); } },
                {"purgeType", n => { PurgeType = n.GetEnumValue<PurgeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PurgeAreas>("purgeAreas", PurgeAreas);
            writer.WriteEnumValue<PurgeType>("purgeType", PurgeType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
