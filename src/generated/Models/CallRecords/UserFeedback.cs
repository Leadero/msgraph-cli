using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.CallRecords {
    public class UserFeedback : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The rating property</summary>
        public UserFeedbackRating? Rating { get; set; }
        /// <summary>The feedback text provided by the user of this endpoint for the session.</summary>
        public string Text { get; set; }
        /// <summary>The set of feedback tokens provided by the user of this endpoint for the session. This is a set of Boolean properties. The property names should not be relied upon since they may change depending on what tokens are offered to the user.</summary>
        public FeedbackTokenSet Tokens { get; set; }
        /// <summary>
        /// Instantiates a new userFeedback and sets the default values.
        /// </summary>
        public UserFeedback() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.callRecords.userFeedback";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserFeedback CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserFeedback();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"rating", n => { Rating = n.GetEnumValue<UserFeedbackRating>(); } },
                {"text", n => { Text = n.GetStringValue(); } },
                {"tokens", n => { Tokens = n.GetObjectValue<FeedbackTokenSet>(FeedbackTokenSet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<UserFeedbackRating>("rating", Rating);
            writer.WriteStringValue("text", Text);
            writer.WriteObjectValue<FeedbackTokenSet>("tokens", Tokens);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}