// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class TrainingNotificationSetting : EndUserNotificationSetting, IParsable {
        /// <summary>Training assignment details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseEndUserNotification? TrainingAssignment { get; set; }
#nullable restore
#else
        public BaseEndUserNotification TrainingAssignment { get; set; }
#endif
        /// <summary>Training reminder details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TrainingReminderNotification? TrainingReminder { get; set; }
#nullable restore
#else
        public TrainingReminderNotification TrainingReminder { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TrainingNotificationSetting"/> and sets the default values.
        /// </summary>
        public TrainingNotificationSetting() : base() {
            OdataType = "#microsoft.graph.trainingNotificationSetting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="TrainingNotificationSetting"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TrainingNotificationSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TrainingNotificationSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"trainingAssignment", n => { TrainingAssignment = n.GetObjectValue<BaseEndUserNotification>(BaseEndUserNotification.CreateFromDiscriminatorValue); } },
                {"trainingReminder", n => { TrainingReminder = n.GetObjectValue<TrainingReminderNotification>(TrainingReminderNotification.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<BaseEndUserNotification>("trainingAssignment", TrainingAssignment);
            writer.WriteObjectValue<TrainingReminderNotification>("trainingReminder", TrainingReminder);
        }
    }
}
