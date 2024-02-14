// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class BaseEndUserNotification : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The default language for the end user notification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultLanguage { get; set; }
#nullable restore
#else
        public string DefaultLanguage { get; set; }
#endif
        /// <summary>The endUserNotification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.EndUserNotification? EndUserNotification { get; set; }
#nullable restore
#else
        public ApiSdk.Models.EndUserNotification EndUserNotification { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BaseEndUserNotification"/> and sets the default values.
        /// </summary>
        public BaseEndUserNotification() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="BaseEndUserNotification"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BaseEndUserNotification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.positiveReinforcementNotification" => new PositiveReinforcementNotification(),
                "#microsoft.graph.simulationNotification" => new SimulationNotification(),
                "#microsoft.graph.trainingReminderNotification" => new TrainingReminderNotification(),
                _ => new BaseEndUserNotification(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultLanguage", n => { DefaultLanguage = n.GetStringValue(); } },
                {"endUserNotification", n => { EndUserNotification = n.GetObjectValue<ApiSdk.Models.EndUserNotification>(ApiSdk.Models.EndUserNotification.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultLanguage", DefaultLanguage);
            writer.WriteObjectValue<ApiSdk.Models.EndUserNotification>("endUserNotification", EndUserNotification);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
