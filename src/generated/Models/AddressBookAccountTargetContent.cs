// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class AddressBookAccountTargetContent : AccountTargetContent, IParsable {
        /// <summary>List of user emails targeted for an attack simulation training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AccountTargetEmails { get; set; }
#nullable restore
#else
        public List<string> AccountTargetEmails { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AddressBookAccountTargetContent"/> and sets the default values.
        /// </summary>
        public AddressBookAccountTargetContent() : base() {
            OdataType = "#microsoft.graph.addressBookAccountTargetContent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="AddressBookAccountTargetContent"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AddressBookAccountTargetContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddressBookAccountTargetContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountTargetEmails", n => { AccountTargetEmails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("accountTargetEmails", AccountTargetEmails);
        }
    }
}
