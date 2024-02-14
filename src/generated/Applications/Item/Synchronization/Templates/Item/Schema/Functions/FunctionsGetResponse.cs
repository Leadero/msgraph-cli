// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Applications.Item.Synchronization.Templates.Item.Schema.Functions {
    public class FunctionsGetResponse : BaseCollectionPaginationCountResponse, IParsable {
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttributeMappingFunctionSchema>? Value { get; set; }
#nullable restore
#else
        public List<AttributeMappingFunctionSchema> Value { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="FunctionsGetResponse"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FunctionsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FunctionsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"value", n => { Value = n.GetCollectionOfObjectValues<AttributeMappingFunctionSchema>(AttributeMappingFunctionSchema.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AttributeMappingFunctionSchema>("value", Value);
        }
    }
}
