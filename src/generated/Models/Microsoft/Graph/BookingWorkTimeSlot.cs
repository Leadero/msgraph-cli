using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class BookingWorkTimeSlot : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The time of the day when work stops. For example, 17:00:00.0000000.</summary>
        public string EndTime { get; set; }
        /// <summary>The time of the day when work starts. For example, 08:00:00.0000000.</summary>
        public string StartTime { get; set; }
        /// <summary>
        /// Instantiates a new bookingWorkTimeSlot and sets the default values.
        /// </summary>
        public BookingWorkTimeSlot() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endTime", (o,n) => { (o as BookingWorkTimeSlot).EndTime = n.GetStringValue(); } },
                {"startTime", (o,n) => { (o as BookingWorkTimeSlot).StartTime = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("endTime", EndTime);
            writer.WriteStringValue("startTime", StartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}