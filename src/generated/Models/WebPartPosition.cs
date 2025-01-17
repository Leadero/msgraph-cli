// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class WebPartPosition : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates the identifier of the column where the web part is located.</summary>
        public double? ColumnId { get; set; }
        /// <summary>Indicates the horizontal section where the web part is located.</summary>
        public double? HorizontalSectionId { get; set; }
        /// <summary>Indicates whether the web part is located in the vertical section.</summary>
        public bool? IsInVerticalSection { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Index of the current web part. Represents the order of the web part in this column or section.</summary>
        public double? WebPartIndex { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WebPartPosition"/> and sets the default values.
        /// </summary>
        public WebPartPosition()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WebPartPosition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WebPartPosition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebPartPosition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"columnId", n => { ColumnId = n.GetDoubleValue(); } },
                {"horizontalSectionId", n => { HorizontalSectionId = n.GetDoubleValue(); } },
                {"isInVerticalSection", n => { IsInVerticalSection = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"webPartIndex", n => { WebPartIndex = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("columnId", ColumnId);
            writer.WriteDoubleValue("horizontalSectionId", HorizontalSectionId);
            writer.WriteBoolValue("isInVerticalSection", IsInVerticalSection);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDoubleValue("webPartIndex", WebPartIndex);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
