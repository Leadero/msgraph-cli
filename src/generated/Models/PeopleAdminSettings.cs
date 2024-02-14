// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class PeopleAdminSettings : Entity, IParsable {
        /// <summary>Contains a collection of the properties an administrator has defined as visible on the Microsoft 365 profile card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProfileCardProperty>? ProfileCardProperties { get; set; }
#nullable restore
#else
        public List<ProfileCardProperty> ProfileCardProperties { get; set; }
#endif
        /// <summary>Represents administrator settings that manage the support of pronouns in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PronounsSettings? Pronouns { get; set; }
#nullable restore
#else
        public PronounsSettings Pronouns { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="PeopleAdminSettings"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PeopleAdminSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PeopleAdminSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"profileCardProperties", n => { ProfileCardProperties = n.GetCollectionOfObjectValues<ProfileCardProperty>(ProfileCardProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"pronouns", n => { Pronouns = n.GetObjectValue<PronounsSettings>(PronounsSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ProfileCardProperty>("profileCardProperties", ProfileCardProperties);
            writer.WriteObjectValue<PronounsSettings>("pronouns", Pronouns);
        }
    }
}
