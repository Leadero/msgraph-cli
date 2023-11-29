// <auto-generated/>
using ApiSdk.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class RetentionLabelSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Describes the item behavior during retention period. Possible values are: doNotRetain, retain, retainAsRecord, retainAsRegulatoryRecord, unknownFutureValue. Read-only.</summary>
        public ApiSdk.Models.Security.BehaviorDuringRetentionPeriod? BehaviorDuringRetentionPeriod { get; set; }
        /// <summary>Specifies whether updates to document content are allowed. Read-only.</summary>
        public bool? IsContentUpdateAllowed { get; set; }
        /// <summary>Specifies whether the document deletion is allowed. Read-only.</summary>
        public bool? IsDeleteAllowed { get; set; }
        /// <summary>Specifies whether you&apos;re allowed to change the retention label on the document. Read-only.</summary>
        public bool? IsLabelUpdateAllowed { get; set; }
        /// <summary>Specifies whether updates to the item metadata (for example, the Title field) are blocked. Read-only.</summary>
        public bool? IsMetadataUpdateAllowed { get; set; }
        /// <summary>Specifies whether the item is locked. Read-write.</summary>
        public bool? IsRecordLocked { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new retentionLabelSettings and sets the default values.
        /// </summary>
        public RetentionLabelSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RetentionLabelSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RetentionLabelSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"behaviorDuringRetentionPeriod", n => { BehaviorDuringRetentionPeriod = n.GetEnumValue<BehaviorDuringRetentionPeriod>(); } },
                {"isContentUpdateAllowed", n => { IsContentUpdateAllowed = n.GetBoolValue(); } },
                {"isDeleteAllowed", n => { IsDeleteAllowed = n.GetBoolValue(); } },
                {"isLabelUpdateAllowed", n => { IsLabelUpdateAllowed = n.GetBoolValue(); } },
                {"isMetadataUpdateAllowed", n => { IsMetadataUpdateAllowed = n.GetBoolValue(); } },
                {"isRecordLocked", n => { IsRecordLocked = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<BehaviorDuringRetentionPeriod>("behaviorDuringRetentionPeriod", BehaviorDuringRetentionPeriod);
            writer.WriteBoolValue("isContentUpdateAllowed", IsContentUpdateAllowed);
            writer.WriteBoolValue("isDeleteAllowed", IsDeleteAllowed);
            writer.WriteBoolValue("isLabelUpdateAllowed", IsLabelUpdateAllowed);
            writer.WriteBoolValue("isMetadataUpdateAllowed", IsMetadataUpdateAllowed);
            writer.WriteBoolValue("isRecordLocked", IsRecordLocked);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
